using System;
using System.IO;
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
    public partial class MainFrame : Form
    {
        // Lists
        internal static List<Player> players;
        internal static List<Match> matches;
        internal static List<Team> teams;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            players = new List<Player>();
            matches = new List<Match>();
            teams = new List<Team>();
            saveToFileToolStripMenuItem.Enabled = false;
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.ShowDialog();
        }

        private void deleteTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTeamForm deleteTeamForm = new DeleteTeamForm();
            deleteTeamForm.ShowDialog();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.ShowDialog();
        }

        private void deletePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePlayerForm deletePlayerForm = new DeletePlayerForm();
            deletePlayerForm.ShowDialog();
        }

        private void addPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddPlayerInTeamForm addPlayerInTeamForm = new AddPlayerInTeamForm();
            addPlayerInTeamForm.ShowDialog();
        }

        private void deletePlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeletePlayerFromTeamForm deletePlayerFromTeamForm = new DeletePlayerFromTeamForm();
            deletePlayerFromTeamForm.ShowDialog();
        }

        private void arrangeMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrangeMatchForm arrangeMatchForm = new ArrangeMatchForm();
            arrangeMatchForm.ShowDialog();
        }

        private void showIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowIntervalForm showIntervalForm = new ShowIntervalForm();
            showIntervalForm.ShowDialog();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output.Columns.Clear();
            output.Columns.Add("Name", "Name");
            output.Columns.Add("Team", "Team");
            foreach (Player player in players)
            {
                string teamName = player.Team != null ? player.Team.Name : "Not in team";
                output.Rows.Add(player.Name, teamName);
            }
            saveToFileToolStripMenuItem.Enabled = true;
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output.Columns.Clear();
            output.Columns.Add("Name", "Name");
            output.Columns.Add("PlayersCount", "Players count");
            output.Columns.Add("MatchesCount", "Matches count");
            foreach (Team team in teams)
            {
                output.Rows.Add(team.Name, team.players.Count, team.matchesPlayed.Count);
            }
            saveToFileToolStripMenuItem.Enabled = true;
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output.Columns.Clear();
            output.Columns.Add("Team1", "Team 1");
            output.Columns.Add("Team2", "Team 2");
            output.Columns.Add("Date", "Date");
            output.Columns.Add("Score", "Score");
            foreach (Match match in matches)
            {
                output.Rows.Add(match.Team1.Name, match.Team2.Name, match.Date.ToShortDateString(), match.Score);
            }
            saveToFileToolStripMenuItem.Enabled = true;
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string text = "";
                foreach (DataGridViewColumn column in output.Columns)
                {
                    text += column.HeaderText + "\t";
                }
                text += Environment.NewLine;
                foreach (DataGridViewRow row in output.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        text += cell.Value.ToString() + "\t\t";
                    }
                    text += Environment.NewLine;
                }
                File.AppendAllText(sfd.FileName, text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal static bool CheckInput(string input, Regex pattern, string errorMessage)
        {
            try
            {
                if (pattern.IsMatch(input))
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(errorMessage);
                return false;
            }
        }

        internal static bool CheckUnique(Player player, List<Player> list)
        {
            try
            {
                if (list.Count != 0)
                {
                    foreach (Player playerInList in list)
                    {
                        if (playerInList.Name == player.Name)
                        {
                            throw new Exception();
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Player already exists");
                return false;
            }
        }

        internal static bool CheckUnique(Team team, List<Team> list)
        {
            try
            {
                if (list.Count != 0)
                {
                    foreach (Team teamInList in list)
                    {
                        if (teamInList.Name == team.Name)
                        {
                            throw new Exception();
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Team already exists");
                return false;
            }
        }

        internal static bool CheckUnique(Match match, List<Match> list)
        {
            try
            {
                if (list.Count != 0)
                {
                    foreach (Match matchInList in list)
                    {
                        if (matchInList.Name == match.Name)
                        {
                            throw new Exception();
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Match has been already arranged");
                return false;
            }
        }
    }

    public class Player
    {
        public string Name { get; }
        public Team Team { get; set; }
        public bool inTeam;

        public Player(string name)
        {
            Name = name;
            Team = null;
            inTeam = false;
        }
    }

    public class Team
    {
        public string Name { get; }
        public List<Player> players;
        public BindingList<string> playersNames;
        public List<Match> matchesPlayed;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
            playersNames = new BindingList<string>();
            matchesPlayed = new List<Match>();
        }
    }

    public class Match
    {
        public Team Team1 { get; }
        public Team Team2 { get; }
        public DateTime Date { get; }
        public string Score { get; }
        public string Name { get; }

        public Match(Team team1, Team team2, DateTime date, string score)
        {
            Team1 = team1;
            Team2 = team2;
            Date = date;
            Score = score;
            Name = team1.Name + " - " + team2.Name + " " + date.ToShortDateString();
        }

        public static int operator -(Match match1, Match match2)
        {
            return (match1.Date - match2.Date).Days;
        }
    }
}
