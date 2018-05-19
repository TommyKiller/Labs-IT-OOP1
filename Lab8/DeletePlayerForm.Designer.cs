namespace Lab8
{
    partial class DeletePlayerForm
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
            this.cancel = new System.Windows.Forms.Button();
            this.deletePlayer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playersList
            // 
            this.playersList.FormattingEnabled = true;
            this.playersList.Location = new System.Drawing.Point(12, 25);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(171, 21);
            this.playersList.TabIndex = 21;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 52);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // deletePlayer
            // 
            this.deletePlayer.Location = new System.Drawing.Point(113, 52);
            this.deletePlayer.Name = "deletePlayer";
            this.deletePlayer.Size = new System.Drawing.Size(70, 21);
            this.deletePlayer.TabIndex = 19;
            this.deletePlayer.Text = "Delete";
            this.deletePlayer.UseVisualStyleBackColor = true;
            this.deletePlayer.Click += new System.EventHandler(this.deletePlayer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select a player:";
            // 
            // DeletePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 85);
            this.Controls.Add(this.playersList);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.deletePlayer);
            this.Controls.Add(this.label4);
            this.Name = "DeletePlayerForm";
            this.Text = "Delete player";
            this.Load += new System.EventHandler(this.DeletePlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox playersList;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button deletePlayer;
        private System.Windows.Forms.Label label4;
    }
}