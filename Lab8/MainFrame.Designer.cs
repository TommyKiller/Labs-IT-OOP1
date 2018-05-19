namespace Lab8
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
            this.output = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.matchManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AllowUserToAddRows = false;
            this.output.AllowUserToDeleteRows = false;
            this.output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output.Location = new System.Drawing.Point(12, 27);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(487, 188);
            this.output.TabIndex = 33;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.showDataBoardToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(511, 24);
            this.mainMenu.TabIndex = 34;
            this.mainMenu.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamToolStripMenuItem,
            this.addPlayerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteTeamToolStripMenuItem,
            this.deletePlayerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addTeamToolStripMenuItem.Text = "Add Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // deleteTeamToolStripMenuItem
            // 
            this.deleteTeamToolStripMenuItem.Name = "deleteTeamToolStripMenuItem";
            this.deleteTeamToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteTeamToolStripMenuItem.Text = "Delete Team";
            this.deleteTeamToolStripMenuItem.Click += new System.EventHandler(this.deleteTeamToolStripMenuItem_Click);
            // 
            // deletePlayerToolStripMenuItem
            // 
            this.deletePlayerToolStripMenuItem.Name = "deletePlayerToolStripMenuItem";
            this.deletePlayerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deletePlayerToolStripMenuItem.Text = "Delete Player";
            this.deletePlayerToolStripMenuItem.Click += new System.EventHandler(this.deletePlayerToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamManagementToolStripMenuItem,
            this.toolStripMenuItem2,
            this.matchManagementToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // teamManagementToolStripMenuItem
            // 
            this.teamManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem1,
            this.deletePlayerToolStripMenuItem1});
            this.teamManagementToolStripMenuItem.Name = "teamManagementToolStripMenuItem";
            this.teamManagementToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.teamManagementToolStripMenuItem.Text = "Team management";
            // 
            // addPlayerToolStripMenuItem1
            // 
            this.addPlayerToolStripMenuItem1.Name = "addPlayerToolStripMenuItem1";
            this.addPlayerToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.addPlayerToolStripMenuItem1.Text = "Add player";
            this.addPlayerToolStripMenuItem1.Click += new System.EventHandler(this.addPlayerToolStripMenuItem1_Click);
            // 
            // deletePlayerToolStripMenuItem1
            // 
            this.deletePlayerToolStripMenuItem1.Name = "deletePlayerToolStripMenuItem1";
            this.deletePlayerToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.deletePlayerToolStripMenuItem1.Text = "Delete player";
            this.deletePlayerToolStripMenuItem1.Click += new System.EventHandler(this.deletePlayerToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(179, 6);
            // 
            // matchManagementToolStripMenuItem
            // 
            this.matchManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeMatchToolStripMenuItem,
            this.showIntervalToolStripMenuItem});
            this.matchManagementToolStripMenuItem.Name = "matchManagementToolStripMenuItem";
            this.matchManagementToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.matchManagementToolStripMenuItem.Text = "Match management";
            // 
            // arrangeMatchToolStripMenuItem
            // 
            this.arrangeMatchToolStripMenuItem.Name = "arrangeMatchToolStripMenuItem";
            this.arrangeMatchToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.arrangeMatchToolStripMenuItem.Text = "Arrange match";
            this.arrangeMatchToolStripMenuItem.Click += new System.EventHandler(this.arrangeMatchToolStripMenuItem_Click);
            // 
            // showIntervalToolStripMenuItem
            // 
            this.showIntervalToolStripMenuItem.Name = "showIntervalToolStripMenuItem";
            this.showIntervalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.showIntervalToolStripMenuItem.Text = "Show interval";
            this.showIntervalToolStripMenuItem.Click += new System.EventHandler(this.showIntervalToolStripMenuItem_Click);
            // 
            // showDataBoardToolStripMenuItem
            // 
            this.showDataBoardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.teamsToolStripMenuItem,
            this.matchesToolStripMenuItem});
            this.showDataBoardToolStripMenuItem.Name = "showDataBoardToolStripMenuItem";
            this.showDataBoardToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.showDataBoardToolStripMenuItem.Text = "Show";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.teamsToolStripMenuItem.Text = "Teams";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // matchesToolStripMenuItem
            // 
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.matchesToolStripMenuItem.Text = "Matches";
            this.matchesToolStripMenuItem.Click += new System.EventHandler(this.matchesToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.saveToFileToolStripMenuItem.Text = "Save to...";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 388);
            this.Controls.Add(this.output);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainFrame";
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView output;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem matchManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

