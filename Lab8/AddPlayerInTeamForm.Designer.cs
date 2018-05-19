namespace Lab8
{
    partial class AddPlayerInTeamForm
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
            this.playersList = new System.Windows.Forms.ComboBox();
            this.teamsList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.addPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playersList
            // 
            this.playersList.FormattingEnabled = true;
            this.playersList.Location = new System.Drawing.Point(112, 25);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(94, 21);
            this.playersList.TabIndex = 17;
            // 
            // teamsList
            // 
            this.teamsList.FormattingEnabled = true;
            this.teamsList.Location = new System.Drawing.Point(12, 25);
            this.teamsList.Name = "teamsList";
            this.teamsList.Size = new System.Drawing.Size(94, 21);
            this.teamsList.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Player:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Team:";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 52);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 19;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(136, 52);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(70, 21);
            this.addPlayer.TabIndex = 18;
            this.addPlayer.Text = "Add";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // AddPlayerInTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 85);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.playersList);
            this.Controls.Add(this.teamsList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "AddPlayerInTeamForm";
            this.Text = "Add player";
            this.Load += new System.EventHandler(this.AddPlayerInTeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox playersList;
        internal System.Windows.Forms.ComboBox teamsList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button addPlayer;
    }
}