using System;
using System.Text.RegularExpressions;
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
    public partial class AddTeamForm : Form
    {
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void registerTeam_Click(object sender, EventArgs e)
        {
            if (teamNameInput.Text != "")
            {
                if (MainFrame.CheckInput(teamNameInput.Text, new Regex(@"^([A-Z]{1}[a-z]{0,}\s?){1,2}[^\s]$"), "Incorrect input! Please, use only A-Z a-z"))
                {
                    Team newTeam = new Team(teamNameInput.Text);
                    if (MainFrame.CheckUnique(newTeam, MainFrame.teams))
                    {
                        MainFrame.teams.Add(newTeam);
                        teamNameInput.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Input team's name");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
