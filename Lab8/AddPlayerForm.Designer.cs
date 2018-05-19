namespace Lab8
{
    partial class AddPlayerForm
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
            this.registerPlayer = new System.Windows.Forms.Button();
            this.playerNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(11, 52);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // registerPlayer
            // 
            this.registerPlayer.Location = new System.Drawing.Point(101, 52);
            this.registerPlayer.Name = "registerPlayer";
            this.registerPlayer.Size = new System.Drawing.Size(70, 21);
            this.registerPlayer.TabIndex = 15;
            this.registerPlayer.Text = "Add";
            this.registerPlayer.UseVisualStyleBackColor = true;
            this.registerPlayer.Click += new System.EventHandler(this.registerPlayer_Click);
            // 
            // playerNameInput
            // 
            this.playerNameInput.Location = new System.Drawing.Point(11, 25);
            this.playerNameInput.Name = "playerNameInput";
            this.playerNameInput.Size = new System.Drawing.Size(160, 20);
            this.playerNameInput.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter a name of a player:";
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 85);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.registerPlayer);
            this.Controls.Add(this.playerNameInput);
            this.Controls.Add(this.label4);
            this.Name = "AddPlayerForm";
            this.Text = "Add player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button registerPlayer;
        private System.Windows.Forms.TextBox playerNameInput;
        private System.Windows.Forms.Label label4;
    }
}