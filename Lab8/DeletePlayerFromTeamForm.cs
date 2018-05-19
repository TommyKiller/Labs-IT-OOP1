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
    public partial class DeletePlayerFromTeamForm : Form
    {
        public DeletePlayerFromTeamForm()
        {
            InitializeComponent();
        }

        private void DeletePlayerFromTeamForm_Load(object sender, EventArgs e)
        {
            foreach (Team team in MainFrame.teams)
            {
                teamsList.Items.Add(team.Name);
            }
            teamsList.DropDownStyle = ComboBoxStyle.DropDownList;

            teamsPlayersList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void teamsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team team in MainFrame.teams)
            {
                if (team.Name == teamsList.Text)
                {
                    teamsPlayersList.DataSource = team.playersNames;
                }
            }
        }

        private void deletePlayer_Click(object sender, EventArgs e)
        {
            foreach (Team team in MainFrame.teams)
            {
                if (team.Name == teamsList.Text)
                {
                    foreach (Player player in MainFrame.players)
                    {
                        if (player.Name == teamsPlayersList.Text)
                        {
                            team.players.Remove(player);
                            team.playersNames.Remove(player.Name);
                            teamsPlayersList.Items.Remove(player.Name);
                            player.Team = null;
                            player.inTeam = false;
                            break;
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
