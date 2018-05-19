namespace Lab9
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
            this.label1 = new System.Windows.Forms.Label();
            this.aWord = new System.Windows.Forms.TextBox();
            this.addWord = new System.Windows.Forms.Button();
            this.aTranslation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dictView = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wTransIn = new System.Windows.Forms.TextBox();
            this.wTransOut = new System.Windows.Forms.Label();
            this.tTransOut = new System.Windows.Forms.Label();
            this.tTransIn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.aLangListFrom = new System.Windows.Forms.ComboBox();
            this.aLangListTo = new System.Windows.Forms.ComboBox();
            this.wLangListTo = new System.Windows.Forms.ComboBox();
            this.wLangListFrom = new System.Windows.Forms.ComboBox();
            this.tLangListTo = new System.Windows.Forms.ComboBox();
            this.tLangListFrom = new System.Windows.Forms.ComboBox();
            this.dictList = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "--------------------------------------------------------------Add word-----------" +
    "--------------------------------------------------";
            // 
            // aWord
            // 
            this.aWord.Location = new System.Drawing.Point(51, 48);
            this.aWord.Name = "aWord";
            this.aWord.Size = new System.Drawing.Size(94, 20);
            this.aWord.TabIndex = 5;
            // 
            // addWord
            // 
            this.addWord.Location = new System.Drawing.Point(168, 46);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(82, 23);
            this.addWord.TabIndex = 7;
            this.addWord.Text = "Add";
            this.addWord.UseVisualStyleBackColor = true;
            this.addWord.Click += new System.EventHandler(this.addWord_Click);
            // 
            // aTranslation
            // 
            this.aTranslation.Location = new System.Drawing.Point(335, 48);
            this.aTranslation.Name = "aTranslation";
            this.aTranslation.Size = new System.Drawing.Size(94, 20);
            this.aTranslation.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "---------------------------------------------------------List dictionaries-------" +
    "--------------------------------------------------";
            // 
            // dictView
            // 
            this.dictView.Location = new System.Drawing.Point(244, 90);
            this.dictView.Name = "dictView";
            this.dictView.Size = new System.Drawing.Size(185, 211);
            this.dictView.TabIndex = 14;
            this.dictView.UseCompatibleStateImageBehavior = false;
            this.dictView.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(419, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "----------------------------------------------------------Translate word---------" +
    "-----------------------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "To:";
            // 
            // wTransIn
            // 
            this.wTransIn.Location = new System.Drawing.Point(439, 51);
            this.wTransIn.Name = "wTransIn";
            this.wTransIn.Size = new System.Drawing.Size(134, 20);
            this.wTransIn.TabIndex = 21;
            this.wTransIn.TextChanged += new System.EventHandler(this.wTransIn_TextChanged);
            // 
            // wTransOut
            // 
            this.wTransOut.AutoSize = true;
            this.wTransOut.Location = new System.Drawing.Point(686, 51);
            this.wTransOut.Name = "wTransOut";
            this.wTransOut.Size = new System.Drawing.Size(0, 13);
            this.wTransOut.TabIndex = 22;
            // 
            // tTransOut
            // 
            this.tTransOut.AutoSize = true;
            this.tTransOut.Location = new System.Drawing.Point(638, 116);
            this.tTransOut.Name = "tTransOut";
            this.tTransOut.Size = new System.Drawing.Size(0, 13);
            this.tTransOut.TabIndex = 28;
            // 
            // tTransIn
            // 
            this.tTransIn.Location = new System.Drawing.Point(439, 116);
            this.tTransIn.Multiline = true;
            this.tTransIn.Name = "tTransIn";
            this.tTransIn.Size = new System.Drawing.Size(193, 185);
            this.tTransIn.TabIndex = 27;
            this.tTransIn.TextChanged += new System.EventHandler(this.tTransIn_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "To:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(419, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "-----------------------------------------------------------Translate text--------" +
    "-------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Translation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Word:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "To:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "From:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "From:";
            // 
            // aLangListFrom
            // 
            this.aLangListFrom.FormattingEnabled = true;
            this.aLangListFrom.Location = new System.Drawing.Point(51, 25);
            this.aLangListFrom.Name = "aLangListFrom";
            this.aLangListFrom.Size = new System.Drawing.Size(94, 21);
            this.aLangListFrom.TabIndex = 34;
            // 
            // aLangListTo
            // 
            this.aLangListTo.FormattingEnabled = true;
            this.aLangListTo.Location = new System.Drawing.Point(335, 25);
            this.aLangListTo.Name = "aLangListTo";
            this.aLangListTo.Size = new System.Drawing.Size(94, 21);
            this.aLangListTo.TabIndex = 35;
            // 
            // wLangListTo
            // 
            this.wLangListTo.FormattingEnabled = true;
            this.wLangListTo.Location = new System.Drawing.Point(715, 25);
            this.wLangListTo.Name = "wLangListTo";
            this.wLangListTo.Size = new System.Drawing.Size(98, 21);
            this.wLangListTo.TabIndex = 37;
            // 
            // wLangListFrom
            // 
            this.wLangListFrom.FormattingEnabled = true;
            this.wLangListFrom.Location = new System.Drawing.Point(475, 25);
            this.wLangListFrom.Name = "wLangListFrom";
            this.wLangListFrom.Size = new System.Drawing.Size(98, 21);
            this.wLangListFrom.TabIndex = 36;
            // 
            // tLangListTo
            // 
            this.tLangListTo.FormattingEnabled = true;
            this.tLangListTo.Location = new System.Drawing.Point(715, 90);
            this.tLangListTo.Name = "tLangListTo";
            this.tLangListTo.Size = new System.Drawing.Size(98, 21);
            this.tLangListTo.TabIndex = 39;
            // 
            // tLangListFrom
            // 
            this.tLangListFrom.FormattingEnabled = true;
            this.tLangListFrom.Location = new System.Drawing.Point(475, 90);
            this.tLangListFrom.Name = "tLangListFrom";
            this.tLangListFrom.Size = new System.Drawing.Size(98, 21);
            this.tLangListFrom.TabIndex = 38;
            // 
            // dictList
            // 
            this.dictList.FormattingEnabled = true;
            this.dictList.Location = new System.Drawing.Point(12, 103);
            this.dictList.Name = "dictList";
            this.dictList.Size = new System.Drawing.Size(133, 21);
            this.dictList.TabIndex = 40;
            this.dictList.SelectedIndexChanged += new System.EventHandler(this.lDictList_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Choose dictionary:";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 369);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dictList);
            this.Controls.Add(this.tLangListTo);
            this.Controls.Add(this.tLangListFrom);
            this.Controls.Add(this.wLangListTo);
            this.Controls.Add(this.wLangListFrom);
            this.Controls.Add(this.aLangListTo);
            this.Controls.Add(this.aLangListFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tTransOut);
            this.Controls.Add(this.tTransIn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.wTransOut);
            this.Controls.Add(this.wTransIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dictView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aTranslation);
            this.Controls.Add(this.addWord);
            this.Controls.Add(this.aWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainFrame";
            this.Text = "Lab";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aWord;
        private System.Windows.Forms.Button addWord;
        private System.Windows.Forms.TextBox aTranslation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wTransIn;
        private System.Windows.Forms.Label wTransOut;
        private System.Windows.Forms.Label tTransOut;
        private System.Windows.Forms.TextBox tTransIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView dictView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox aLangListFrom;
        private System.Windows.Forms.ComboBox aLangListTo;
        private System.Windows.Forms.ComboBox wLangListTo;
        private System.Windows.Forms.ComboBox wLangListFrom;
        private System.Windows.Forms.ComboBox tLangListTo;
        private System.Windows.Forms.ComboBox tLangListFrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox dictList;
    }
}

