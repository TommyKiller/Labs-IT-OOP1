using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (LabTask.CheckInput(tInput.Text, nInput.Text))
            {
                double a = Convert.ToDouble(tInput.Text);
                int b = Convert.ToInt32(nInput.Text, 10);
                resultLable.Text = string.Format("x({0}; {1}) = {2}", a, b, LabTask.Calculate(a, b));
            }
            else
            {
                resultLable.Text = "Wrong input";
            }
        }
    }

    class LabTask
    {
        public static Boolean CheckInput(string t, string n)
        {
            try
            {
                double a = Convert.ToDouble(t);
                int b = Convert.ToInt32(n);
                if (b <= 0)
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

        public static double Calculate(double a, int b)
        {
            double result = 0;
            if (a < 0)
            {
                for (int i = 1; i <= b; i++)
                {
                    result += Math.Pow(a, 2) * i;
                }
            }
            else
            {
                for (int i = 1; i <= b; i++)
                {
                    result += Math.Sqrt((a * i));
                }
            }
            return result;
        }
    }
}
