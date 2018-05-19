namespace Lab10
{
    partial class Lab10
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
            this.FileLoad = new System.Windows.Forms.Button();
            this.AnalyzeText = new System.Windows.Forms.Button();
            this.fileOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FileLoad
            // 
            this.FileLoad.Location = new System.Drawing.Point(448, 9);
            this.FileLoad.Name = "FileLoad";
            this.FileLoad.Size = new System.Drawing.Size(60, 22);
            this.FileLoad.TabIndex = 0;
            this.FileLoad.Text = "Load File";
            this.FileLoad.UseVisualStyleBackColor = true;
            this.FileLoad.Click += new System.EventHandler(this.FileLoad_Click);
            // 
            // AnalyzeText
            // 
            this.AnalyzeText.Location = new System.Drawing.Point(448, 37);
            this.AnalyzeText.Name = "AnalyzeText";
            this.AnalyzeText.Size = new System.Drawing.Size(77, 22);
            this.AnalyzeText.TabIndex = 2;
            this.AnalyzeText.Text = "Analyze Text";
            this.AnalyzeText.UseVisualStyleBackColor = true;
            this.AnalyzeText.Click += new System.EventHandler(this.AnalyzeText_Click);
            // 
            // fileOutput
            // 
            this.fileOutput.Location = new System.Drawing.Point(12, 9);
            this.fileOutput.Name = "fileOutput";
            this.fileOutput.Size = new System.Drawing.Size(430, 429);
            this.fileOutput.TabIndex = 3;
            this.fileOutput.Text = "";
            // 
            // Lab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.fileOutput);
            this.Controls.Add(this.AnalyzeText);
            this.Controls.Add(this.FileLoad);
            this.Name = "Lab10";
            this.Text = "Lab10";
            this.Load += new System.EventHandler(this.Lab10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FileLoad;
        private System.Windows.Forms.Button AnalyzeText;
        private System.Windows.Forms.RichTextBox fileOutput;
    }
}

