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
    public partial class AddPlayerInTeamForm : Form
    {
        public AddPlayerInTeamForm()
        {
            InitializeComponent();
        }

        private void AddPlayerInTeamForm_Load(object sender, EventArgs e)
        {
            foreach (Team team in MainFrame.teams)
            {
                teamsList.Items.Add(team.Name);
            }
            teamsList.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Player player in MainFrame.players)
            {
                if (!player.inTeam)
                    playersList.Items.Add(player.Name);
            }
            playersList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            foreach (Team team in MainFrame.teams)
            {
                if (team.Name == teamsList.Text)
                {
                    foreach (Player player in MainFrame.players)
                    {
                        if (player.Name == playersList.Text)
                        {
                            if (!player.inTeam)
                            {
                                team.players.Add(player);
                                team.playersNames.Add(player.Name);
                                player.Team = team;
                                player.inTeam = true;
                                playersList.Items.Remove(player.Name);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Player is already in team");
                            }
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
