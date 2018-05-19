namespace Lab8
{
    partial class ArrangeMatchForm
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
            this.team2List = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.team1List = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cancel = new System.Windows.Forms.Button();
            this.registerMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // team2List
            // 
            this.team2List.FormattingEnabled = true;
            this.team2List.Location = new System.Drawing.Point(128, 25);
            this.team2List.Name = "team2List";
            this.team2List.Size = new System.Drawing.Size(110, 21);
            this.team2List.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Team 2:";
            // 
            // team1List
            // 
            this.team1List.FormattingEnabled = true;
            this.team1List.Location = new System.Drawing.Point(12, 25);
            this.team1List.Name = "team1List";
            this.team1List.Size = new System.Drawing.Size(110, 21);
            this.team1List.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Team 1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Score:";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(128, 65);
            this.score.Mask = "00:00";
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(32, 20);
            this.score.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Date:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(12, 65);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(110, 20);
            this.date.TabIndex = 31;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 91);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 33;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // registerMatch
            // 
            this.registerMatch.Location = new System.Drawing.Point(168, 91);
            this.registerMatch.Name = "registerMatch";
            this.registerMatch.Size = new System.Drawing.Size(70, 21);
            this.registerMatch.TabIndex = 32;
            this.registerMatch.Text = "Arrange";
            this.registerMatch.UseVisualStyleBackColor = true;
            this.registerMatch.Click += new System.EventHandler(this.registerMatch_Click);
            // 
            // ArrangeMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 124);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.registerMatch);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.team2List);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.team1List);
            this.Controls.Add(this.label10);
            this.Name = "ArrangeMatchForm";
            this.Text = "Arrange match";
            this.Load += new System.EventHandler(this.ArrangeMatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox team2List;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox team1List;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox score;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button registerMatch;
    }
}