namespace Lab8
{
    partial class ShowIntervalForm
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
            this.OK = new System.Windows.Forms.Button();
            this.match2List = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.match1List = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 65);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 43;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(168, 65);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(70, 21);
            this.OK.TabIndex = 42;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // match2List
            // 
            this.match2List.FormattingEnabled = true;
            this.match2List.Location = new System.Drawing.Point(128, 25);
            this.match2List.Name = "match2List";
            this.match2List.Size = new System.Drawing.Size(110, 21);
            this.match2List.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Match 2:";
            // 
            // match1List
            // 
            this.match1List.FormattingEnabled = true;
            this.match1List.Location = new System.Drawing.Point(12, 25);
            this.match1List.Name = "match1List";
            this.match1List.Size = new System.Drawing.Size(110, 21);
            this.match1List.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Match 1:";
            // 
            // interval
            // 
            this.interval.AutoSize = true;
            this.interval.Location = new System.Drawing.Point(110, 49);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(0, 13);
            this.interval.TabIndex = 44;
            // 
            // ShowIntervalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 122);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.match2List);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.match1List);
            this.Controls.Add(this.label10);
            this.Name = "ShowIntervalForm";
            this.Text = "Show interval";
            this.Load += new System.EventHandler(this.ShowIntervalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox match2List;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox match1List;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label interval;
    }
}