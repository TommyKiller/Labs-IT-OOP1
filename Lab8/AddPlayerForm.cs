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
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void registerPlayer_Click(object sender, EventArgs e)
        {
            if (playerNameInput.Text != "")
            {
                if (MainFrame.CheckInput(playerNameInput.Text, new Regex(@"^([A-Z]{1}[a-z]{0,}\s?){1,}[^\s]$"), "Incorrect input! Please, use only A-Z a-z"))
                {
                    Player newPlayer = new Player(playerNameInput.Text);
                    if (MainFrame.CheckUnique(newPlayer, MainFrame.players))
                    {
                        MainFrame.players.Add(newPlayer);
                        playerNameInput.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Input player's name");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
