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
    public partial class DeleteTeamForm : Form
    {
        public DeleteTeamForm()
        {
            InitializeComponent();
        }

        
        private void DeleteTeamForm_Load(object sender, EventArgs e)
        {
            foreach (Team team in MainFrame.teams)
            {
                teamsList.Items.Add(team.Name);
            }
            teamsList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void deleteTeam_Click(object sender, EventArgs e)
        {
            if (teamsList.Text != "")
            {
                foreach (Team team in MainFrame.teams)
                {
                    if (team.Name == teamsList.Text)
                    {
                        FreePlayers(team);
                        MainFrame.teams.Remove(team);
                        teamsList.Items.Remove(team.Name);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a team");
            }
        }

        private void FreePlayers(Team team)
        {
            foreach (Player player in MainFrame.players)
            {
                if (team.players.Contains(player))
                {
                    player.Team = null;
                    player.inTeam = false;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
