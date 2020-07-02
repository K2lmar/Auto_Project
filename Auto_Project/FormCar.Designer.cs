namespace Auto_Project
{
    partial class FormCar
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewCar = new System.Windows.Forms.ListView();
            this.labelModelCar = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelStateNumber = new System.Windows.Forms.Label();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            this.textBoxModelCar = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxStateNumber = new System.Windows.Forms.TextBox();
            this.textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Auto_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(2, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(237, 84);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonAdd.Location = new System.Drawing.Point(272, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 48);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonEdit.Location = new System.Drawing.Point(456, 325);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(127, 48);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonDel.Location = new System.Drawing.Point(634, 325);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(127, 48);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewCar
            // 
            this.listViewCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCar.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.listViewCar.FullRowSelect = true;
            this.listViewCar.GridLines = true;
            this.listViewCar.HideSelection = false;
            this.listViewCar.Location = new System.Drawing.Point(245, -1);
            this.listViewCar.MultiSelect = false;
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(552, 317);
            this.listViewCar.TabIndex = 4;
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            this.listViewCar.View = System.Windows.Forms.View.Details;
            this.listViewCar.SelectedIndexChanged += new System.EventHandler(this.listViewCar_SelectedIndexChanged);
            // 
            // labelModelCar
            // 
            this.labelModelCar.AutoSize = true;
            this.labelModelCar.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelModelCar.Location = new System.Drawing.Point(12, 86);
            this.labelModelCar.Name = "labelModelCar";
            this.labelModelCar.Size = new System.Drawing.Size(74, 23);
            this.labelModelCar.TabIndex = 5;
            this.labelModelCar.Text = "Модель";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelColor.Location = new System.Drawing.Point(12, 144);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(47, 23);
            this.labelColor.TabIndex = 6;
            this.labelColor.Text = "Цвет";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelPrice.Location = new System.Drawing.Point(12, 203);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 23);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Цена";
            // 
            // labelStateNumber
            // 
            this.labelStateNumber.AutoSize = true;
            this.labelStateNumber.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelStateNumber.Location = new System.Drawing.Point(14, 261);
            this.labelStateNumber.Name = "labelStateNumber";
            this.labelStateNumber.Size = new System.Drawing.Size(86, 23);
            this.labelStateNumber.TabIndex = 8;
            this.labelStateNumber.Text = "Госномер";
            // 
            // labelReleaseYear
            // 
            this.labelReleaseYear.AutoSize = true;
            this.labelReleaseYear.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelReleaseYear.Location = new System.Drawing.Point(14, 319);
            this.labelReleaseYear.Name = "labelReleaseYear";
            this.labelReleaseYear.Size = new System.Drawing.Size(107, 23);
            this.labelReleaseYear.TabIndex = 9;
            this.labelReleaseYear.Text = "Год выпуска";
            // 
            // textBoxModelCar
            // 
            this.textBoxModelCar.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxModelCar.Location = new System.Drawing.Point(16, 112);
            this.textBoxModelCar.Name = "textBoxModelCar";
            this.textBoxModelCar.Size = new System.Drawing.Size(192, 29);
            this.textBoxModelCar.TabIndex = 10;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(16, 170);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(192, 30);
            this.comboBoxColor.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxPrice.Location = new System.Drawing.Point(16, 229);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(192, 29);
            this.textBoxPrice.TabIndex = 12;
            // 
            // textBoxStateNumber
            // 
            this.textBoxStateNumber.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxStateNumber.Location = new System.Drawing.Point(16, 287);
            this.textBoxStateNumber.Name = "textBoxStateNumber";
            this.textBoxStateNumber.Size = new System.Drawing.Size(192, 29);
            this.textBoxStateNumber.TabIndex = 13;
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxReleaseYear.Location = new System.Drawing.Point(16, 345);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.Size = new System.Drawing.Size(192, 29);
            this.textBoxReleaseYear.TabIndex = 14;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Модель";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цвет";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Госномер";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Год выпуска";
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.textBoxReleaseYear);
            this.Controls.Add(this.textBoxStateNumber);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.textBoxModelCar);
            this.Controls.Add(this.labelReleaseYear);
            this.Controls.Add(this.labelStateNumber);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelModelCar);
            this.Controls.Add(this.listViewCar);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Logo);
            this.Name = "FormCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.Label labelModelCar;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelStateNumber;
        private System.Windows.Forms.Label labelReleaseYear;
        private System.Windows.Forms.TextBox textBoxModelCar;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStateNumber;
        private System.Windows.Forms.TextBox textBoxReleaseYear;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}