namespace Lab8
{
    partial class AddTeamForm
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
            this.registerTeam = new System.Windows.Forms.Button();
            this.teamNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerTeam
            // 
            this.registerTeam.Location = new System.Drawing.Point(98, 52);
            this.registerTeam.Name = "registerTeam";
            this.registerTeam.Size = new System.Drawing.Size(70, 21);
            this.registerTeam.TabIndex = 11;
            this.registerTeam.Text = "Add";
            this.registerTeam.UseVisualStyleBackColor = true;
            this.registerTeam.Click += new System.EventHandler(this.registerTeam_Click);
            // 
            // teamNameInput
            // 
            this.teamNameInput.Location = new System.Drawing.Point(12, 25);
            this.teamNameInput.Name = "teamNameInput";
            this.teamNameInput.Size = new System.Drawing.Size(156, 20);
            this.teamNameInput.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter a name of a team:";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 52);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 85);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.registerTeam);
            this.Controls.Add(this.teamNameInput);
            this.Controls.Add(this.label4);
            this.Name = "AddTeamForm";
            this.Text = "Add team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerTeam;
        private System.Windows.Forms.TextBox teamNameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel;
    }
}