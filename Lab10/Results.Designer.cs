namespace Lab10
{
    partial class Results
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
            this.resultsOutput = new System.Windows.Forms.DataGridView();
            this.selectTable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultsOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsOutput
            // 
            this.resultsOutput.AllowUserToAddRows = false;
            this.resultsOutput.AllowUserToDeleteRows = false;
            this.resultsOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsOutput.Location = new System.Drawing.Point(109, 12);
            this.resultsOutput.Name = "resultsOutput";
            this.resultsOutput.ReadOnly = true;
            this.resultsOutput.Size = new System.Drawing.Size(268, 426);
            this.resultsOutput.TabIndex = 0;
            // 
            // selectTable
            // 
            this.selectTable.FormattingEnabled = true;
            this.selectTable.Items.AddRange(new object[] {
            "Symbols",
            "Words"});
            this.selectTable.Location = new System.Drawing.Point(12, 12);
            this.selectTable.Name = "selectTable";
            this.selectTable.Size = new System.Drawing.Size(84, 21);
            this.selectTable.TabIndex = 1;
            this.selectTable.SelectedIndexChanged += new System.EventHandler(this.selectTable_SelectedIndexChanged);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.selectTable);
            this.Controls.Add(this.resultsOutput);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsOutput;
        private System.Windows.Forms.ComboBox selectTable;
    }
}