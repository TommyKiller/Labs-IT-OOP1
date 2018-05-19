namespace Lab8
{
    partial class DeletePlayerFromTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel = new System.Windows.Forms.Button();
            this.deletePlayer = new System.Windows.Forms.Button();
            this.teamsList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teamsPlayersList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 52);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 25;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // deletePlayer
            // 
            this.deletePlayer.Location = new System.Drawing.Point(136, 52);
            this.deletePlayer.Name = "deletePlayer";
            this.deletePlayer.Size = new System.Drawing.Size(70, 21);
            this.deletePlayer.TabIndex = 24;
            this.deletePlayer.Text = "Delete";
            this.deletePlayer.UseVisualStyleBackColor = true;
            this.deletePlayer.Click += new System.EventHandler(this.deletePlayer_Click);
            // 
            // teamsList
            // 
            this.teamsList.FormattingEnabled = true;
            this.teamsList.Location = new System.Drawing.Point(12, 25);
            this.teamsList.Name = "teamsList";
            this.teamsList.Size = new System.Drawing.Size(94, 21);
            this.teamsList.TabIndex = 22;
            this.teamsList.SelectedIndexChanged += new System.EventHandler(this.teamsList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Player:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Team:";
            // 
            // teamsPlayersList
            // 
            this.teamsPlayersList.FormattingEnabled = true;
            this.teamsPlayersList.Location = new System.Drawing.Point(112, 25);
            this.teamsPlayersList.Name = "teamsPlayersList";
            this.teamsPlayersList.Size = new System.Drawing.Size(94, 21);
            this.teamsPlayersList.TabIndex = 26;
            // 
            // DeletePlayerFromTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 85);
            this.Controls.Add(this.teamsPlayersList);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.deletePlayer);
            this.Controls.Add(this.teamsList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "DeletePlayerFromTeamForm";
            this.Text = "Delete player";
            this.Load += new System.EventHandler(this.DeletePlayerFromTeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button deletePlayer;
        internal System.Windows.Forms.ComboBox teamsList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox teamsPlayersList;
    }
}