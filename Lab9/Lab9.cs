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

namespace Lab9
{
    public partial class MainFrame : Form
    {
        // Components
        public static List<string> languages;
        public static List<ComboBox> langLists;
        public static Dictionary<string, Dictionary<string, string>> dictionaries;

        // Flags
        bool isChanging;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            languages = new List<string>
            {
                "Arabian",
                "Ukranian"
            };
            dictionaries = new Dictionary<string, Dictionary<string, string>>
            {
                { "Arabian - Ukranian", new Dictionary<string, string>() },
                { "Ukranian - Arabian", new Dictionary<string, string>() }
            };

            // "Ukranian - Arabian"
            dictionaries["Ukranian - Arabian"].Add("доброго дня", "مساء الخير");
            dictionaries["Ukranian - Arabian"].Add("шлях", "الطريق");
            dictionaries["Ukranian - Arabian"].Add("навчання", "تعليم");
            dictionaries["Ukranian - Arabian"].Add("йти до мети", "اذهب الى الهدف");
            dictionaries["Ukranian - Arabian"].Add("зупинка", "توقف");
            dictionaries["Ukranian - Arabian"].Add("спати", "للنوم");
            dictionaries["Ukranian - Arabian"].Add("щільно", "المكتظة");
            dictionaries["Ukranian - Arabian"].Add("дружба", "صداقة");
            dictionaries["Ukranian - Arabian"].Add("чимало", "كثير");
            dictionaries["Ukranian - Arabian"].Add("найбагатший", "أغنى");

            // "Arabian - Ukranian"
            dictionaries["Arabian - Ukranian"].Add("مساء الخير", "доброго дня");
            dictionaries["Arabian - Ukranian"].Add("الطريق", "шлях");
            dictionaries["Arabian - Ukranian"].Add("تعليم", "навчання");
            dictionaries["Arabian - Ukranian"].Add("اذهب الى الهدف", "йти до мети");
            dictionaries["Arabian - Ukranian"].Add("توقف", "зупинка");
            dictionaries["Arabian - Ukranian"].Add("للنوم", "спати");
            dictionaries["Arabian - Ukranian"].Add("المكتظة", "щільно");
            dictionaries["Arabian - Ukranian"].Add("صداقة", "дружба");
            dictionaries["Arabian - Ukranian"].Add("كثير", "чимало");
            dictionaries["Arabian - Ukranian"].Add("أغنى", "найбагатший");

            langLists = new List<ComboBox>
            {
                aLangListFrom,
                aLangListTo,
                wLangListFrom,
                wLangListTo,
                tLangListFrom,
                tLangListTo
            };
            LabTask.UpdateLangLists();
            foreach (string dictionary in dictionaries.Keys)
            {
                if (!dictList.Items.Contains(dictionary)) dictList.Items.Add(dictionary);
            }
            isChanging = false;
        }

        private void addWord_Click(object sender, EventArgs e)
        {
            string originalLang = aLangListFrom.Text;
            string translationLang = aLangListTo.Text;
            if (LabTask.CheckInput(new string[] { originalLang, translationLang }))
            {
                if (LabTask.CheckDictionary(originalLang + " - " + translationLang))
                {
                    string word = aWord.Text;
                    string translation = aTranslation.Text;
                    if (LabTask.CheckInput(new string[] { word, translation }))
                    {
                        if (!dictionaries[originalLang + " - " + translationLang].Keys.Contains(word))
                        {
                            dictionaries[originalLang + " - " + translationLang].Add(word, translation);
                        }
                        else MessageBox.Show("Translation already exists");
                    }
                    else MessageBox.Show("Input value");
                }
                else MessageBox.Show("Dictionary doesn't exist");
            }
            else MessageBox.Show("Select languages");
        }

        private void lDictList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dictView.Items.Clear();
            foreach (KeyValuePair<string, string> word in dictionaries[dictList.Text])
            {
                dictView.Items.Add(word.ToString());
            }
        }

        private void wTransIn_TextChanged(object sender, EventArgs e)
        {
            string originalLang = wLangListFrom.Text;
            string translationLang = wLangListTo.Text;
            if (LabTask.CheckInput(new string[] { originalLang, translationLang }))
            {
                if (LabTask.CheckDictionary(originalLang + " - " + translationLang))
                {
                    string word = wTransIn.Text;
                    if (dictionaries[originalLang + " - " + translationLang].Keys.Contains(word))
                    {
                        wTransOut.Text = dictionaries[originalLang + " - " + translationLang][word];
                    }
                }
                else MessageBox.Show("Dictionary doesn't exist");
            }
            else MessageBox.Show("Select languages");
        }

        private void tTransIn_TextChanged(object sender, EventArgs e)
        {
            if (!isChanging)
            {
                isChanging = true;
                string output = tTransIn.Text;
                string originalLang = tLangListFrom.Text;
                string translationLang = tLangListTo.Text;
                if (LabTask.CheckInput(new string[] { originalLang, translationLang }))
                {
                    if (LabTask.CheckDictionary(originalLang + " - " + translationLang))
                    {
                        foreach (string word in dictionaries[originalLang + " - " + translationLang].Keys)
                        {
                            output = Regex.Replace(output.ToLower(), word.ToLower(), dictionaries[originalLang + " - " + translationLang][word]);
                        }
                        tTransOut.Text = output;
                    }
                    else MessageBox.Show("Dictionary doesn't exist");
                }
                else MessageBox.Show("Select languages");
                isChanging = false;
            }
        }
    }

    public static class LabTask
    {
        public static bool CheckInput(string input)
        {
            if (input == "") return false;
            else return true;
        }

        public static bool CheckInput(string[] inputStrings)
        {
            foreach (string input in inputStrings)
            {
                if (input == "") return false;
            }
            return true;
        }

        public static bool CheckDictionary(string dictName)
        {
            foreach (string dictionary in MainFrame.dictionaries.Keys)
            {
                if (dictionary == dictName) return true;
            }
            return false;
        }

        public static void UpdateLangLists()
        {
            foreach (string language in MainFrame.languages)
            {
                foreach (ComboBox langList in MainFrame.langLists)
                {
                    if (!langList.Items.Contains(language)) langList.Items.Add(language);
                }
            }
        }
    }
}
