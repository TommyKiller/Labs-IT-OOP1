using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            AutoSize = true;
            LableCreating("elemsNumberLbl", "Input number of elements:", 9, new Point(0, 0));
            TextBoxCreating("elemsNumberInput", "1", new Point(150, 00));
            LableCreating("taskLbl",
                "Task 1.A: find the sum of negative items.\n" +
                "Task 1.B: find the sum of items in which the index is multiple 3.\n" +
                "Task 1.C: find the product of the largest's and smallest's elements modules.\n" +
                "Task 2: check quadratic matrix for the of increasing sequences.",
                10, new Point(350, 0));
            ButtonCreating("task1ABtn", "Calculate Task 1.A:", new Point(0, 20));
            Controls["task1ABtn"].Click += new EventHandler(task1ABtn_Click);
            LableCreating("task1ALbl", "", 9, new Point(115, 20));
            ButtonCreating("task1BBtn", "Calculate Task 1.B:", new Point(0, 40));
            Controls["task1BBtn"].Click += new EventHandler(task1BBtn_Click);
            LableCreating("task1BLbl", "", 9, new Point(115, 40));
            ButtonCreating("task1CBtn", "Calculate Task 1.C:", new Point(0, 60));
            Controls["task1CBtn"].Click += new EventHandler(task1CBtn_Click);
            LableCreating("task1CLbl", "", 9, new Point(115, 60));
            ButtonCreating("task2Btn", "Calculate Task 2:", new Point(0, 80));
            Controls["task2Btn"].Click += new EventHandler(task2Btn_Click);
            LableCreating("task2Lbl", "", 9, new Point(115, 80));
            LableCreating("errorLbl", "", 9, new Point(350, 70));
            arrayGrid.Location = new Point(350, 100);
            arrayGrid.AutoSize = true;
            arrayGrid.Visible = false;
        }

        private void task1ABtn_Click(object sender, EventArgs e)
        {
            if (LabTask.CheckInput(Controls["elemsNumberInput"].Text))
            {
                IncorrectInput("");
                int n = Convert.ToInt32(Controls["elemsNumberInput"].Text);
                double[] array = LabTask.CreateArray(n);
                double result = LabTask.FindSumOfNegative(array);
                if (result != 0)
                {
                    Controls["task1ALbl"].Text = Convert.ToString(result);
                    ArrayOutput(array);
                }
                else
                {
                    IncorrectInput("Array doesn't contain any negative elements.");
                }
            }
            else
            {
                IncorrectInput("Incorrect input!");
            }
        }

        private void task1BBtn_Click(object sender, EventArgs e)
        {
            if (LabTask.CheckInput(Controls["elemsNumberInput"].Text))
            {
                IncorrectInput("");
                int n = Convert.ToInt32(Controls["elemsNumberInput"].Text);
                double[] array = LabTask.CreateArray(n);
                double result = LabTask.FindSumOfElems3(array);
                if (array.Length >= 4)
                {
                    Controls["task1BLbl"].Text = Convert.ToString(result);
                    ArrayOutput(array);
                }
                else
                {
                    IncorrectInput("Array doesn't contain any elements with index is a multiple of 3.");
                }
            }
            else
            {
                IncorrectInput("Incorrect input!");
            }
        }

        private void task1CBtn_Click(object sender, EventArgs e)
        {
            if (LabTask.CheckInput(Controls["elemsNumberInput"].Text))
            {
                IncorrectInput("");
                int n = Convert.ToInt32(Controls["elemsNumberInput"].Text);
                double[] array = LabTask.CreateArray(n);
                double result = LabTask.FindMultOfMinMax(array);
                Controls["task1CLbl"].Text = Convert.ToString(result);
                ArrayOutput(array);
            }
            else
            {
                IncorrectInput("Incorrect input!");
            }
        }

        private void task2Btn_Click(object sender, EventArgs e)
        {
            if (LabTask.CheckInput(Controls["elemsNumberInput"].Text))
            {
                int n = Convert.ToInt32(Controls["elemsNumberInput"].Text);
                if (n > 2)
                {
                    IncorrectInput("");
                    double[,] array = LabTask.CreateArray(n, n);
                    double[] result = LabTask.FindSequence(array);
                    string resultStr = "";
                    for (int i = 0; i < result.Length; i++)
                    {
                        resultStr += Convert.ToString(result[i]);
                    }
                    Controls["task2Lbl"].Text = resultStr;
                    ArrayOutput(array);
                }
                else
                {
                    IncorrectInput("Please, input n > 2.");
                }
            }
            else
            {
                IncorrectInput("Incorrect input!");
            }
        }

        private void ArrayOutput(double[] array)
        {
            if (arrayGrid.ColumnCount != array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayGrid.Columns.Add("arrayElement", Convert.ToString(i));
                }
            }
            arrayGrid.Rows.Add();
            for (int i = 0; i < array.Length; i++)
            {
                arrayGrid[i, arrayGrid.RowCount - 1].Value = array[i];
            }
            arrayGrid.Visible = true;
        }

        private void ArrayOutput(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                arrayGrid.Columns.Add("columnIndex", Convert.ToString(i));
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                arrayGrid.Rows.Add();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrayGrid[j, i].Value = array[i, j];
                }
            }
            arrayGrid.Visible = true;
        }

        private void IncorrectInput(string error)
        {
            Controls["task1ALbl"].Text = "";
            Controls["task1BLbl"].Text = "";
            Controls["task1CLbl"].Text = "";
            Controls["task2Lbl"].Text = "";
            Controls["errorLbl"].Text = error;
            arrayGrid.Columns.Clear();
        }

        private void DataGridViewCreating(string name, Point location)
        {
            DataGridView NewArrayGrid = new DataGridView();
            NewArrayGrid.Name = name;
            NewArrayGrid.Location = location;
            NewArrayGrid.AutoSize = true;
            NewArrayGrid.AllowUserToAddRows = false;
            Controls.Add(NewArrayGrid);
        }

        private void ButtonCreating(string name, string text, Point location)
        {
            Button NewButton = new Button();
            NewButton.Name = name;
            NewButton.Text = text;
            NewButton.AutoSize = true;
            NewButton.Location = location;
            Controls.Add(NewButton);
        }

        private void TextBoxCreating(string name, string text, Point location)
        {
            TextBox NewTextBox = new TextBox();
            NewTextBox.Name = name;
            NewTextBox.Text = text;
            NewTextBox.Location = location;
            Controls.Add(NewTextBox);
        }

        private void LableCreating(string name, string text, int fontScale, Point location)
        {
            Label NewLabel = new Label();
            NewLabel.Name = name;
            NewLabel.Font = new Font(NewLabel.Font.Name, fontScale, NewLabel.Font.Style);
            NewLabel.Text = text;
            NewLabel.AutoSize = true;
            NewLabel.Location = location;
            Controls.Add(NewLabel);
        }
    }

    class LabTask
    {
        public static Boolean CheckInput(string value)
        {
            try
            {
                int convertedValue = Convert.ToInt32(value);
                if (convertedValue <= 0)
                {
                    throw new ArgumentException();
                }
                return true;
            }

            catch (FormatException)
            {
                return false;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public static double[] CreateArray(int n)
        {
            double[] newArray = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                newArray[i] = (rnd.NextDouble() * 2 * Math.Pow(10, 2)) - Math.Pow(10, 2);
            }
            return newArray;
        }

        public static double[,] CreateArray(int n, int m)
        {
            double[,] newArray = new double[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newArray[i, j] = (rnd.NextDouble() * 2 * Math.Pow(10, 100)) - Math.Pow(10, 100);
                }
            }
            return newArray;
        }

        public static Boolean CheckSequence(double[] sequence)
        {
            Boolean isGrowing = true;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    isGrowing = false;
                }
            }
            return isGrowing;
        }

        public static double FindSumOfNegative(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static double FindSumOfElems3(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (((i % 3) == 0) && (i != 0))
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static double FindMultOfMinMax(double[] array)
        {
            double max = Double.NegativeInfinity;
            double min = Double.PositiveInfinity;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return Math.Abs(min) * Math.Abs(max);
        }

        public static double[] FindSequence(double[,] array)
        {
            double[] resultArray = new double[array.GetLength(0)];
            double[] sequence = new double[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sequence[j] = array[i, j];
                }
                if (CheckSequence(sequence))
                {
                    resultArray[i] = 1;
                }
                else
                {
                    resultArray[i] = 0;
                }
            }
            return resultArray;
        }
    }
}
