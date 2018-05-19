namespace Lab4
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
            this.output = new System.Windows.Forms.DataGridView();
            this.idLable = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.brandInput = new System.Windows.Forms.TextBox();
            this.brandLable = new System.Windows.Forms.Label();
            this.typeLable = new System.Windows.Forms.Label();
            this.mileageInput = new System.Windows.Forms.TextBox();
            this.mileageLable = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.errorLable = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.indexInput = new System.Windows.Forms.TextBox();
            this.sortCbb = new System.Windows.Forms.ComboBox();
            this.typeInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.findTypeInput = new System.Windows.Forms.ComboBox();
            this.findMileageInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.findBrandInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.findNameInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.findIdInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AllowUserToDeleteRows = false;
            this.output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output.Location = new System.Drawing.Point(6, 143);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(743, 167);
            this.output.TabIndex = 0;
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Location = new System.Drawing.Point(6, 15);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(21, 13);
            this.idLable.TabIndex = 1;
            this.idLable.Text = "ID:";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(33, 12);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(76, 20);
            this.idInput.TabIndex = 2;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(159, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(82, 20);
            this.nameInput.TabIndex = 4;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(115, 15);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(38, 13);
            this.nameLable.TabIndex = 3;
            this.nameLable.Text = "Name:";
            // 
            // brandInput
            // 
            this.brandInput.Location = new System.Drawing.Point(287, 12);
            this.brandInput.Name = "brandInput";
            this.brandInput.Size = new System.Drawing.Size(73, 20);
            this.brandInput.TabIndex = 6;
            // 
            // brandLable
            // 
            this.brandLable.AutoSize = true;
            this.brandLable.Location = new System.Drawing.Point(247, 15);
            this.brandLable.Name = "brandLable";
            this.brandLable.Size = new System.Drawing.Size(38, 13);
            this.brandLable.TabIndex = 5;
            this.brandLable.Text = "Brand:";
            // 
            // typeLable
            // 
            this.typeLable.AutoSize = true;
            this.typeLable.Location = new System.Drawing.Point(366, 15);
            this.typeLable.Name = "typeLable";
            this.typeLable.Size = new System.Drawing.Size(34, 13);
            this.typeLable.TabIndex = 7;
            this.typeLable.Text = "Type:";
            // 
            // mileageInput
            // 
            this.mileageInput.Location = new System.Drawing.Point(565, 12);
            this.mileageInput.Name = "mileageInput";
            this.mileageInput.Size = new System.Drawing.Size(68, 20);
            this.mileageInput.TabIndex = 10;
            // 
            // mileageLable
            // 
            this.mileageLable.AutoSize = true;
            this.mileageLable.Location = new System.Drawing.Point(512, 15);
            this.mileageLable.Name = "mileageLable";
            this.mileageLable.Size = new System.Drawing.Size(47, 13);
            this.mileageLable.TabIndex = 9;
            this.mileageLable.Text = "Mileage:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(782, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 20);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // errorLable
            // 
            this.errorLable.AutoSize = true;
            this.errorLable.Location = new System.Drawing.Point(14, 39);
            this.errorLable.Name = "errorLable";
            this.errorLable.Size = new System.Drawing.Size(0, 13);
            this.errorLable.TabIndex = 12;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(231, 110);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(73, 27);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(517, 110);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(82, 27);
            this.sortBtn.TabIndex = 18;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(782, 22);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(100, 20);
            this.InsertBtn.TabIndex = 19;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // indexInput
            // 
            this.indexInput.Location = new System.Drawing.Point(752, 12);
            this.indexInput.Name = "indexInput";
            this.indexInput.Size = new System.Drawing.Size(21, 20);
            this.indexInput.TabIndex = 20;
            // 
            // sortCbb
            // 
            this.sortCbb.FormattingEnabled = true;
            this.sortCbb.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Brand",
            "Type",
            "Mileage"});
            this.sortCbb.Location = new System.Drawing.Point(398, 113);
            this.sortCbb.Name = "sortCbb";
            this.sortCbb.Size = new System.Drawing.Size(113, 21);
            this.sortCbb.TabIndex = 21;
            // 
            // typeInput
            // 
            this.typeInput.FormattingEnabled = true;
            this.typeInput.Items.AddRange(new object[] {
            "SUV",
            "truck",
            "passenger"});
            this.typeInput.Location = new System.Drawing.Point(406, 12);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(87, 21);
            this.typeInput.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Index (for insert only):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(865, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________________________________________________";
            // 
            // deleteField
            // 
            this.deleteField.FormattingEnabled = true;
            this.deleteField.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Brand",
            "Type",
            "Mileage"});
            this.deleteField.Location = new System.Drawing.Point(38, 110);
            this.deleteField.Name = "deleteField";
            this.deleteField.Size = new System.Drawing.Size(79, 21);
            this.deleteField.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Field:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Value:";
            // 
            // deleteInput
            // 
            this.deleteInput.Location = new System.Drawing.Point(166, 111);
            this.deleteInput.Name = "deleteInput";
            this.deleteInput.Size = new System.Drawing.Size(59, 20);
            this.deleteInput.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Field:";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(648, 68);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(73, 27);
            this.findBtn.TabIndex = 30;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findTypeInput
            // 
            this.findTypeInput.FormattingEnabled = true;
            this.findTypeInput.Items.AddRange(new object[] {
            "SUV",
            "truck",
            "passenger"});
            this.findTypeInput.Location = new System.Drawing.Point(400, 72);
            this.findTypeInput.Name = "findTypeInput";
            this.findTypeInput.Size = new System.Drawing.Size(87, 21);
            this.findTypeInput.TabIndex = 42;
            // 
            // findMileageInput
            // 
            this.findMileageInput.Location = new System.Drawing.Point(559, 72);
            this.findMileageInput.Name = "findMileageInput";
            this.findMileageInput.Size = new System.Drawing.Size(68, 20);
            this.findMileageInput.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Mileage:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Type:";
            // 
            // findBrandInput
            // 
            this.findBrandInput.Location = new System.Drawing.Point(281, 72);
            this.findBrandInput.Name = "findBrandInput";
            this.findBrandInput.Size = new System.Drawing.Size(73, 20);
            this.findBrandInput.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Brand:";
            // 
            // findNameInput
            // 
            this.findNameInput.Location = new System.Drawing.Point(153, 72);
            this.findNameInput.Name = "findNameInput";
            this.findNameInput.Size = new System.Drawing.Size(82, 20);
            this.findNameInput.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Name:";
            // 
            // findIdInput
            // 
            this.findIdInput.Location = new System.Drawing.Point(27, 72);
            this.findIdInput.Name = "findIdInput";
            this.findIdInput.Size = new System.Drawing.Size(76, 20);
            this.findIdInput.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(865, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "_________________________________________________________________________________" +
    "______________________________________________________________";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 413);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.findTypeInput);
            this.Controls.Add(this.findMileageInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.findBrandInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.findNameInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.findIdInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.sortCbb);
            this.Controls.Add(this.indexInput);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.errorLable);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.mileageInput);
            this.Controls.Add(this.mileageLable);
            this.Controls.Add(this.typeLable);
            this.Controls.Add(this.brandInput);
            this.Controls.Add(this.brandLable);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.idLable);
            this.Controls.Add(this.output);
            this.Name = "MainFrame";
            this.Text = "Lab7";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView output;
        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox brandInput;
        private System.Windows.Forms.Label brandLable;
        private System.Windows.Forms.Label typeLable;
        private System.Windows.Forms.TextBox mileageInput;
        private System.Windows.Forms.Label mileageLable;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label errorLable;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox indexInput;
        private System.Windows.Forms.ComboBox sortCbb;
        private System.Windows.Forms.ComboBox typeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deleteField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deleteInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.ComboBox findTypeInput;
        private System.Windows.Forms.TextBox findMileageInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox findBrandInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox findNameInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox findIdInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
    }
}

