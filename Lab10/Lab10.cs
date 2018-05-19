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

namespace Lab10
{
    public partial class Lab10 : Form
    {
        // Components
        public static SortedList<string, int> Symbols;
        public static SortedList<string, int> Words;

        public Lab10()
        {
            InitializeComponent();
        }

        private void Lab10_Load(object sender, EventArgs e)
        {
            Symbols = new SortedList<string, int>();
            Words = new SortedList<string, int>();
            fileOutput.ReadOnly = true;
        }

        private void FileLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                string filePath = od.FileName;
                fileOutput.Text = File.ReadAllText(filePath);
            }
        }

        private void AnalyzeText_Click(object sender, EventArgs e)
        {
            Symbols.Clear();
            Words.Clear();

            foreach (Match match in Regex.Matches(fileOutput.Text, @"[a-z]", RegexOptions.IgnoreCase))
            {
                string value = match.Value.ToLower();
                if (Symbols.ContainsKey(value))
                    Symbols[value] += 1;
                else Symbols.Add(value, 1);
            }

            foreach (Match match in Regex.Matches(fileOutput.Text, @"\b([a-z]+)(-[a-z]+)*\b", RegexOptions.IgnoreCase))
            {
                string value = match.Value.ToLower();
                if (Words.ContainsKey(value))
                    Words[value] += 1;
                else Words.Add(value, 1);
            }
            Results resultsForm = new Results();
            resultsForm.ShowDialog();
        }
    }
}
