namespace Lab1
{
    partial class MainFrame
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.tInput = new System.Windows.Forms.TextBox();
            this.nInput = new System.Windows.Forms.TextBox();
            this.inputLable = new System.Windows.Forms.Label();
            this.tValue = new System.Windows.Forms.Label();
            this.nValue = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 76);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // tInput
            // 
            this.tInput.Location = new System.Drawing.Point(37, 28);
            this.tInput.Name = "tInput";
            this.tInput.Size = new System.Drawing.Size(100, 20);
            this.tInput.TabIndex = 1;
            // 
            // nInput
            // 
            this.nInput.Location = new System.Drawing.Point(37, 50);
            this.nInput.Name = "nInput";
            this.nInput.Size = new System.Drawing.Size(100, 20);
            this.nInput.TabIndex = 2;
            // 
            // inputLable
            // 
            this.inputLable.AutoSize = true;
            this.inputLable.Location = new System.Drawing.Point(12, 9);
            this.inputLable.Name = "inputLable";
            this.inputLable.Size = new System.Drawing.Size(76, 13);
            this.inputLable.TabIndex = 3;
            this.inputLable.Text = "Input variables";
            // 
            // tValue
            // 
            this.tValue.AutoSize = true;
            this.tValue.Location = new System.Drawing.Point(12, 31);
            this.tValue.Name = "tValue";
            this.tValue.Size = new System.Drawing.Size(19, 13);
            this.tValue.TabIndex = 4;
            this.tValue.Text = "t =";
            // 
            // nValue
            // 
            this.nValue.AutoSize = true;
            this.nValue.Location = new System.Drawing.Point(12, 53);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(22, 13);
            this.nValue.TabIndex = 5;
            this.nValue.Text = "n =";
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(93, 81);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(0, 13);
            this.resultLable.TabIndex = 6;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.nValue);
            this.Controls.Add(this.tValue);
            this.Controls.Add(this.inputLable);
            this.Controls.Add(this.nInput);
            this.Controls.Add(this.tInput);
            this.Controls.Add(this.calculateBtn);
            this.Name = "MainFrame";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox tInput;
        private System.Windows.Forms.TextBox nInput;
        private System.Windows.Forms.Label inputLable;
        private System.Windows.Forms.Label tValue;
        private System.Windows.Forms.Label nValue;
        private System.Windows.Forms.Label resultLable;
    }
}

