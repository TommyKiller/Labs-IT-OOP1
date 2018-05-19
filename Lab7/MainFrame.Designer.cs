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
            this.typeInput = new System.Windows.Forms.TextBox();
            this.typeLable = new System.Windows.Forms.Label();
            this.mileageInput = new System.Windows.Forms.TextBox();
            this.mileageLable = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.errorLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AllowUserToDeleteRows = false;
            this.output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output.Location = new System.Drawing.Point(192, 32);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(563, 167);
            this.output.TabIndex = 0;
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Location = new System.Drawing.Point(12, 9);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(21, 13);
            this.idLable.TabIndex = 1;
            this.idLable.Text = "ID:";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(39, 6);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(103, 20);
            this.idInput.TabIndex = 2;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(192, 6);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(103, 20);
            this.nameInput.TabIndex = 4;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(148, 9);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(38, 13);
            this.nameLable.TabIndex = 3;
            this.nameLable.Text = "Name:";
            // 
            // brandInput
            // 
            this.brandInput.Location = new System.Drawing.Point(341, 6);
            this.brandInput.Name = "brandInput";
            this.brandInput.Size = new System.Drawing.Size(103, 20);
            this.brandInput.TabIndex = 6;
            // 
            // brandLable
            // 
            this.brandLable.AutoSize = true;
            this.brandLable.Location = new System.Drawing.Point(301, 9);
            this.brandLable.Name = "brandLable";
            this.brandLable.Size = new System.Drawing.Size(38, 13);
            this.brandLable.TabIndex = 5;
            this.brandLable.Text = "Brand:";
            // 
            // typeInput
            // 
            this.typeInput.Location = new System.Drawing.Point(490, 6);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(103, 20);
            this.typeInput.TabIndex = 8;
            // 
            // typeLable
            // 
            this.typeLable.AutoSize = true;
            this.typeLable.Location = new System.Drawing.Point(450, 9);
            this.typeLable.Name = "typeLable";
            this.typeLable.Size = new System.Drawing.Size(34, 13);
            this.typeLable.TabIndex = 7;
            this.typeLable.Text = "Type:";
            // 
            // mileageInput
            // 
            this.mileageInput.Location = new System.Drawing.Point(652, 6);
            this.mileageInput.Name = "mileageInput";
            this.mileageInput.Size = new System.Drawing.Size(103, 20);
            this.mileageInput.TabIndex = 10;
            // 
            // mileageLable
            // 
            this.mileageLable.AutoSize = true;
            this.mileageLable.Location = new System.Drawing.Point(599, 9);
            this.mileageLable.Name = "mileageLable";
            this.mileageLable.Size = new System.Drawing.Size(47, 13);
            this.mileageLable.TabIndex = 9;
            this.mileageLable.Text = "Mileage:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(39, 32);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(103, 27);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // errorLable
            // 
            this.errorLable.AutoSize = true;
            this.errorLable.Location = new System.Drawing.Point(12, 41);
            this.errorLable.Name = "errorLable";
            this.errorLable.Size = new System.Drawing.Size(0, 13);
            this.errorLable.TabIndex = 12;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 261);
            this.Controls.Add(this.errorLable);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.mileageInput);
            this.Controls.Add(this.mileageLable);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.typeLable);
            this.Controls.Add(this.brandInput);
            this.Controls.Add(this.brandLable);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.idLable);
            this.Controls.Add(this.output);
            this.Name = "MainFrame";
            this.Text = "Lab4";
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
        private System.Windows.Forms.TextBox typeInput;
        private System.Windows.Forms.Label typeLable;
        private System.Windows.Forms.TextBox mileageInput;
        private System.Windows.Forms.Label mileageLable;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label errorLable;
    }
}

