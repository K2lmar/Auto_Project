namespace Auto_Project
{
    partial class FormFirm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelNameCompany = new System.Windows.Forms.Label();
            this.textBoxNameCompany = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.listViewFirm = new System.Windows.Forms.ListView();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonAdd.Location = new System.Drawing.Point(283, 331);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 48);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonEdit.Location = new System.Drawing.Point(472, 331);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(127, 48);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonDel.Location = new System.Drawing.Point(641, 331);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(127, 48);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.AutoSize = true;
            this.labelNameCompany.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelNameCompany.Location = new System.Drawing.Point(12, 85);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(148, 23);
            this.labelNameCompany.TabIndex = 3;
            this.labelNameCompany.Text = "Название фирмы";
            // 
            // textBoxNameCompany
            // 
            this.textBoxNameCompany.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxNameCompany.Location = new System.Drawing.Point(16, 111);
            this.textBoxNameCompany.Name = "textBoxNameCompany";
            this.textBoxNameCompany.Size = new System.Drawing.Size(192, 29);
            this.textBoxNameCompany.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxAddress.Location = new System.Drawing.Point(16, 169);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(192, 29);
            this.textBoxAddress.TabIndex = 5;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelAddress.Location = new System.Drawing.Point(12, 143);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 23);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Адрес";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelCity.Location = new System.Drawing.Point(15, 201);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 23);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "Город";
            // 
            // Logo
            // 
            this.Logo.Image = global::Auto_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(4, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(237, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // listViewFirm
            // 
            this.listViewFirm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewFirm.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.listViewFirm.FullRowSelect = true;
            this.listViewFirm.GridLines = true;
            this.listViewFirm.HideSelection = false;
            this.listViewFirm.Location = new System.Drawing.Point(247, 2);
            this.listViewFirm.MultiSelect = false;
            this.listViewFirm.Name = "listViewFirm";
            this.listViewFirm.Size = new System.Drawing.Size(551, 314);
            this.listViewFirm.TabIndex = 9;
            this.listViewFirm.UseCompatibleStateImageBehavior = false;
            this.listViewFirm.View = System.Windows.Forms.View.Details;
            this.listViewFirm.SelectedIndexChanged += new System.EventHandler(this.listViewFirm_SelectedIndexChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxCity.Location = new System.Drawing.Point(16, 227);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(192, 29);
            this.textBoxCity.TabIndex = 10;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelPhone.Location = new System.Drawing.Point(15, 261);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(77, 23);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxPhone.Location = new System.Drawing.Point(16, 287);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(192, 29);
            this.textBoxPhone.TabIndex = 12;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Адрес";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Город";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            // 
            // FormFirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.listViewFirm);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxNameCompany);
            this.Controls.Add(this.labelNameCompany);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormFirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фирмы";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelNameCompany;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ListView listViewFirm;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}