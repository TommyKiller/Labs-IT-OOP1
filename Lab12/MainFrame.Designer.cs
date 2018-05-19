namespace Lab12
{
    partial class MainFrame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.caseSensitivity = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameInput = new System.Windows.Forms.ToolStripTextBox();
            this.searchStart = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.currentFolderStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.filesList = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolder,
            this.caseSensitivity,
            this.fileNameInput,
            this.searchStart});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(268, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectFolder
            // 
            this.selectFolder.Image = ((System.Drawing.Image)(resources.GetObject("selectFolder.Image")));
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(28, 23);
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // caseSensitivity
            // 
            this.caseSensitivity.Name = "caseSensitivity";
            this.caseSensitivity.Size = new System.Drawing.Size(12, 23);
            this.caseSensitivity.Click += new System.EventHandler(this.caseSensitivity_Click);
            // 
            // fileNameInput
            // 
            this.fileNameInput.Name = "fileNameInput";
            this.fileNameInput.Size = new System.Drawing.Size(100, 23);
            this.fileNameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileNameInput_KeyDown);
            // 
            // searchStart
            // 
            this.searchStart.Image = ((System.Drawing.Image)(resources.GetObject("searchStart.Image")));
            this.searchStart.Name = "searchStart";
            this.searchStart.Size = new System.Drawing.Size(28, 23);
            this.searchStart.Click += new System.EventHandler(this.searchStart_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentFolderStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(268, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // currentFolderStatus
            // 
            this.currentFolderStatus.Name = "currentFolderStatus";
            this.currentFolderStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // filesList
            // 
            this.filesList.Location = new System.Drawing.Point(12, 30);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(244, 234);
            this.filesList.TabIndex = 2;
            this.filesList.UseCompatibleStateImageBehavior = false;
            this.filesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesList_MouseDoubleClick);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 289);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.Text = "Lab12";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox fileNameInput;
        private System.Windows.Forms.ToolStripMenuItem searchStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentFolderStatus;
        private System.Windows.Forms.ToolStripMenuItem selectFolder;
        private System.Windows.Forms.ToolStripMenuItem caseSensitivity;
        private System.Windows.Forms.ListView filesList;
    }
}

