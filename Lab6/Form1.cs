using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (inputTxt.Text.Contains('*'))
            {
                string outputStr1 = "";
                string outputStr2 = inputTxt.Text;
                string outputStr = "";
                for (int i = 0; i < inputTxt.Text.IndexOf('*'); i++)
                {
                    if ((new Regex(@"[a-z]")).IsMatch(Convert.ToString(inputTxt.Text[i])))
                    {
                        outputStr1 += 3;
                    }
                    else outputStr1 += inputTxt.Text[i];
                }
                outputStr2 = outputStr2.Remove(0, inputTxt.Text.IndexOf('*'));
                outputStr = String.Concat(outputStr1, outputStr2);
                outputLbl.Text = outputStr;
            }
            else outputLbl.Text = inputTxt.Text;
        }
    }
}
