using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab5
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.Cancel) return;
            string filename = openDialog.FileName;
            inputLbl.Text = File.ReadAllText(filename);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            if (LabTask.CheckInput(inputLbl.Text))
            {
                outputLbl.Text = LabTask.Rewrite(inputLbl.Text);
            }
            else
            {
                MessageBox.Show("Incorrect input!");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveDialog.FileName;
            File.WriteAllText(filename, outputLbl.Text);
        }
    }

    public class LabTask
    {
        public static bool CheckInput(string inputText)
        {
            try
            {
                int posNumb = 0;
                int negNumb = 0;
                string[] text = inputText.Split(' ');
                foreach (string value in text)
                {
                    int x = Convert.ToInt32(value);
                    if (x > 0) ++posNumb;
                    else if (x < 0) ++negNumb;
                    else if (x == 0) throw new Exception();
                }
                if (posNumb != negNumb) throw new Exception();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static string Rewrite(string input)
        {
            string[] text = input.Split(' ');
            string posString = "";
            string negString = "";
            foreach (string value in text)
            {
                int x = Convert.ToInt32(value);
                if (x > 0) posString += value + " ";
                else if (x < 0) negString += value + " ";
            }
            string result = posString;
            result += negString;
            return result;
        }
    }
}
