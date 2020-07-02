namespace Auto_Project
{
    partial class FormAvailability
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
            this.labelIdFirms = new System.Windows.Forms.Label();
            this.labelIdCars = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxIdFirms = new System.Windows.Forms.ComboBox();
            this.comboBoxIdCars = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.listViewAvailability = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdFirms
            // 
            this.labelIdFirms.AutoSize = true;
            this.labelIdFirms.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelIdFirms.Location = new System.Drawing.Point(18, 98);
            this.labelIdFirms.Name = "labelIdFirms";
            this.labelIdFirms.Size = new System.Drawing.Size(65, 23);
            this.labelIdFirms.TabIndex = 0;
            this.labelIdFirms.Text = "Фирма";
            // 
            // labelIdCars
            // 
            this.labelIdCars.AutoSize = true;
            this.labelIdCars.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelIdCars.Location = new System.Drawing.Point(18, 170);
            this.labelIdCars.Name = "labelIdCars";
            this.labelIdCars.Size = new System.Drawing.Size(109, 23);
            this.labelIdCars.TabIndex = 1;
            this.labelIdCars.Text = "Автомобиль";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonAdd.Location = new System.Drawing.Point(283, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 48);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonEdit.Location = new System.Drawing.Point(446, 282);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(127, 48);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonDel.Location = new System.Drawing.Point(619, 282);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(127, 48);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxIdFirms
            // 
            this.comboBoxIdFirms.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.comboBoxIdFirms.FormattingEnabled = true;
            this.comboBoxIdFirms.Location = new System.Drawing.Point(22, 124);
            this.comboBoxIdFirms.Name = "comboBoxIdFirms";
            this.comboBoxIdFirms.Size = new System.Drawing.Size(192, 30);
            this.comboBoxIdFirms.TabIndex = 5;
            // 
            // comboBoxIdCars
            // 
            this.comboBoxIdCars.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.comboBoxIdCars.FormattingEnabled = true;
            this.comboBoxIdCars.Location = new System.Drawing.Point(22, 196);
            this.comboBoxIdCars.Name = "comboBoxIdCars";
            this.comboBoxIdCars.Size = new System.Drawing.Size(192, 30);
            this.comboBoxIdCars.TabIndex = 6;
            // 
            // Logo
            // 
            this.Logo.Image = global::Auto_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(1, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(226, 85);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // listViewAvailability
            // 
            this.listViewAvailability.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewAvailability.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.listViewAvailability.FullRowSelect = true;
            this.listViewAvailability.GridLines = true;
            this.listViewAvailability.HideSelection = false;
            this.listViewAvailability.Location = new System.Drawing.Point(233, 0);
            this.listViewAvailability.MultiSelect = false;
            this.listViewAvailability.Name = "listViewAvailability";
            this.listViewAvailability.Size = new System.Drawing.Size(568, 266);
            this.listViewAvailability.TabIndex = 8;
            this.listViewAvailability.UseCompatibleStateImageBehavior = false;
            this.listViewAvailability.View = System.Windows.Forms.View.Details;
            this.listViewAvailability.SelectedIndexChanged += new System.EventHandler(this.listViewAvailability_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id наличия";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фирма";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Автомобиль";
            // 
            // FormAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.listViewAvailability);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.comboBoxIdCars);
            this.Controls.Add(this.comboBoxIdFirms);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelIdCars);
            this.Controls.Add(this.labelIdFirms);
            this.Name = "FormAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наличие";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdFirms;
        private System.Windows.Forms.Label labelIdCars;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxIdFirms;
        private System.Windows.Forms.ComboBox comboBoxIdCars;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ListView listViewAvailability;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}