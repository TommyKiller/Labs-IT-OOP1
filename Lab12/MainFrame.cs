using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab12
{
    public partial class MainFrame : Form
    {
        private bool isSensitive;
        public bool IsSensitive
        {
            get
            {
                return isSensitive;
            }
            set
            {
                isSensitive = value;
                if (isSensitive)
                    caseSensitivity.Image = Properties.Resources.arrowUpIcon;
                else
                    caseSensitivity.Image = Properties.Resources.arrowDownIcon;
            }
        }

        List<string> files;
        ImageList fileImages;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            IsSensitive = false;
            currentFolderStatus.Text = Directory.GetCurrentDirectory();
            filesList.MultiSelect = false;
        }

        private void searchStart_Click(object sender, EventArgs e)
        {
            if (fileNameInput.Text != "")
            {
                string fileName = String.Format("*{0}*", fileNameInput.Text);
                ParseTemplate(ref fileName);
                fileImages = new ImageList();
                files = new List<string>();
                try
                {
                    Search(currentFolderStatus.Text, fileName, IsSensitive);
                    Output();
                }
                catch (Exception)
                {
                    MessageBox.Show("Access denied");
                }
            }
        }

        private void fileNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchStart_Click(sender, e);
            }
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                currentFolderStatus.Text = fbd.SelectedPath;
            }
        }

        private void caseSensitivity_Click(object sender, EventArgs e)
        {
            IsSensitive = !IsSensitive;
        }

        private void ParseTemplate(ref string template)
        {
            char[] operands = new char[] { '*', '?' };
            string inserts = "[0-9a-zA-Z. -]";
            for (int i = 0; i < template.Length; i++)
            {
                if (operands.Contains(template[i]))
                {
                    template = template.Insert(i, inserts);
                    i += inserts.Length;
                }
            }
        }

        private void Search(string currentFolder, string fileName, bool isSensitive)
        {
            List<string> filePaths = new List<string>();


            filePaths.AddRange(Directory.EnumerateFiles(currentFolder));
            FilterFiles(fileName, ref filePaths, isSensitive);

            if (filePaths.Count > 0)
            {
                foreach (string file in filePaths)
                {
                    files.Add(file);
                    fileImages.Images.Add(Icon.ExtractAssociatedIcon(file));
                }
            }

            List<string> directories = new List<string>();
            directories.AddRange(Directory.EnumerateDirectories(currentFolder));
            if (directories.Count > 0)
            {
                foreach (string directory in directories)
                {
                    Search(directory, fileName, isSensitive);
                }
            }
        }

        private void FilterFiles(string template, ref List<string> filePaths, bool isSensetive)
        {
            for (int i = 0; i < filePaths.Count; i++)
            {
                if (isSensetive)
                {
                    if (!new Regex(template).IsMatch(filePaths[i]))
                    {
                        filePaths.Remove(filePaths[i]);
                        i--;
                    }
                }
                else
                {
                    if (!new Regex(template, RegexOptions.IgnoreCase).IsMatch(filePaths[i]))
                    {
                        filePaths.Remove(filePaths[i]);
                        i--;
                    }
                }
            }
        }

        private void Output()
        {
            filesList.Items.Clear();
            filesList.LargeImageList = fileImages;
            for (int i = 0; i < files.Count; i++)
            {
                filesList.Items.Add(files[i], i);
            }
        }

        private void filesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (filesList.SelectedItems.Count == 1)
            {
                Process openFolder = new Process();
                openFolder.StartInfo.FileName = "explorer";
                string fullPath = filesList.SelectedItems[0].Text;
                string fileName = fullPath.Split('\\').Last();
                string path = fullPath.Remove(fullPath.LastIndexOf(fileName) - 1);
                openFolder.StartInfo.Arguments = path;
                openFolder.Start();
                openFolder.Close();
            }
        }
    }
}
