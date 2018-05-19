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
    public partial class ArrangeMatchForm : Form
    {
        public ArrangeMatchForm()
        {
            InitializeComponent();
        }

        private void ArrangeMatchForm_Load(object sender, EventArgs e)
        {
            foreach (Team team in MainFrame.teams)
            {
                team1List.Items.Add(team.Name);
                team2List.Items.Add(team.Name);
            }
            team1List.DropDownStyle = ComboBoxStyle.DropDownList;
            team2List.DropDownStyle = ComboBoxStyle.DropDownList;
            date.MaxDate = DateTime.Now;
        }

        private void registerMatch_Click(object sender, EventArgs e)
        {
            foreach (Team team1 in MainFrame.teams)
            {
                if (team1.Name == team1List.Text)
                {
                    foreach (Team team2 in MainFrame.teams)
                    {
                        if (team2.Name == team2List.Text)
                        {
                            if (team1 != team2)
                            {
                                if ((team1.players.Count != 0) && (team2.players.Count != 0))
                                {
                                    if (MainFrame.CheckInput(score.Text, new Regex(@"\d{2}:\d{2}"), "Enter the score"))
                                    {
                                        Match newMatch = new Match(team1, team2, Convert.ToDateTime(date.Text), score.Text);
                                        if (MainFrame.CheckUnique(newMatch, MainFrame.matches))
                                        {
                                            MainFrame.matches.Add(newMatch);
                                            team1.matchesPlayed.Add(newMatch);
                                            team2.matchesPlayed.Add(newMatch);
                                            team1List.SelectedItem = null;
                                            team2List.SelectedItem = null;
                                            score.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("One of the teams is empty");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Choose different teams");
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
