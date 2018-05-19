using System;
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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            selectTable.DropDownStyle = ComboBoxStyle.DropDownList;
            resultsOutput.Columns.Add("Key", "Symbol/word");
            resultsOutput.Columns.Add("Value", "Number of Repetitions");
        }

        private void selectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentList = selectTable.Text;
            resultsOutput.Rows.Clear();
            switch (currentList)
            {
                case "Symbols":
                    foreach (string item in Lab10.Symbols.Keys)
                    {
                        resultsOutput.Rows.Add(item, Lab10.Symbols[item]);
                    }
                    break;
                case "Words":
                    foreach (string item in Lab10.Words.Keys)
                    {
                        resultsOutput.Rows.Add(item, Lab10.Words[item]);
                    }
                    break;
            }
        }
    }
}
