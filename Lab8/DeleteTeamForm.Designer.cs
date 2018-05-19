namespace Lab8
{
    partial class DeleteTeamForm
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
            this.deleteTeam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.teamsList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 52);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // deleteTeam
            // 
            this.deleteTeam.Location = new System.Drawing.Point(108, 52);
            this.deleteTeam.Name = "deleteTeam";
            this.deleteTeam.Size = new System.Drawing.Size(70, 21);
            this.deleteTeam.TabIndex = 15;
            this.deleteTeam.Text = "Delete";
            this.deleteTeam.UseVisualStyleBackColor = true;
            this.deleteTeam.Click += new System.EventHandler(this.deleteTeam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select a team:";
            // 
            // teamsList
            // 
            this.teamsList.FormattingEnabled = true;
            this.teamsList.Location = new System.Drawing.Point(12, 25);
            this.teamsList.Name = "teamsList";
            this.teamsList.Size = new System.Drawing.Size(166, 21);
            this.teamsList.TabIndex = 17;
            // 
            // DeleteTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 85);
            this.Controls.Add(this.teamsList);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.deleteTeam);
            this.Controls.Add(this.label4);
            this.Name = "DeleteTeamForm";
            this.Text = "Delete team";
            this.Load += new System.EventHandler(this.DeleteTeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button deleteTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox teamsList;
    }
}