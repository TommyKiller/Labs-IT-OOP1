using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class ShowIntervalForm : Form
    {
        public ShowIntervalForm()
        {
            InitializeComponent();
        }

        private void ShowIntervalForm_Load(object sender, EventArgs e)
        {
            foreach (Match match in MainFrame.matches)
            {
                match1List.Items.Add(match.Name);
                match2List.Items.Add(match.Name);
            }
            match1List.DropDownStyle = ComboBoxStyle.DropDownList;
            match2List.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            foreach (Match match1 in MainFrame.matches)
            {
                if (match1.Name == match1List.Text)
                {
                    foreach (Match match2 in MainFrame.matches)
                    {
                        if (match2.Name == match2List.Text)
                        {
                            if (match1 != match2)
                            {
                                interval.Text = Convert.ToString(Math.Abs(match1 - match2)) + " days";
                            }
                            else
                            {
                                MessageBox.Show("Choose different matches");
                            }
                        }
                    }
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
