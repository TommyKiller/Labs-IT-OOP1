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
    public partial class DeletePlayerForm : Form
    {
        public DeletePlayerForm()
        {
            InitializeComponent();
        }

        private void DeletePlayerForm_Load(object sender, EventArgs e)
        {
            foreach (Player player in MainFrame.players)
            {
                playersList.Items.Add(player.Name);
            }
            playersList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void deletePlayer_Click(object sender, EventArgs e)
        {
            if (playersList.Text != "")
            {
                foreach (Player player in MainFrame.players)
                {
                    if (player.Name == playersList.Text)
                    {
                        RemoveFromTeam(player);
                        MainFrame.players.Remove(player);
                        playersList.Items.Remove(player.Name);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a player");
            }
        }

        private void RemoveFromTeam(Player player)
        {
            foreach (Team team in MainFrame.teams)
            {
                if (team.players.Contains(player))
                {
                    team.players.Remove(player);
                    team.playersNames.Remove(player.Name);
                    break;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
