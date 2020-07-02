namespace Auto_Project
{
    partial class Menu
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
            this.buttonOpenFirms = new System.Windows.Forms.Button();
            this.buttonOpenCars = new System.Windows.Forms.Button();
            this.buttonOpenAvailabilitys = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFirms
            // 
            this.buttonOpenFirms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonOpenFirms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFirms.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonOpenFirms.Location = new System.Drawing.Point(3, 145);
            this.buttonOpenFirms.Name = "buttonOpenFirms";
            this.buttonOpenFirms.Size = new System.Drawing.Size(232, 48);
            this.buttonOpenFirms.TabIndex = 0;
            this.buttonOpenFirms.Text = "Фирмы";
            this.buttonOpenFirms.UseVisualStyleBackColor = false;
            this.buttonOpenFirms.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpenCars
            // 
            this.buttonOpenCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonOpenCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenCars.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonOpenCars.Location = new System.Drawing.Point(3, 203);
            this.buttonOpenCars.Name = "buttonOpenCars";
            this.buttonOpenCars.Size = new System.Drawing.Size(232, 48);
            this.buttonOpenCars.TabIndex = 1;
            this.buttonOpenCars.Text = "Автомобили";
            this.buttonOpenCars.UseVisualStyleBackColor = false;
            this.buttonOpenCars.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // buttonOpenAvailabilitys
            // 
            this.buttonOpenAvailabilitys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonOpenAvailabilitys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAvailabilitys.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonOpenAvailabilitys.Location = new System.Drawing.Point(3, 258);
            this.buttonOpenAvailabilitys.Name = "buttonOpenAvailabilitys";
            this.buttonOpenAvailabilitys.Size = new System.Drawing.Size(232, 48);
            this.buttonOpenAvailabilitys.TabIndex = 2;
            this.buttonOpenAvailabilitys.Text = "Наличие";
            this.buttonOpenAvailabilitys.UseVisualStyleBackColor = false;
            this.buttonOpenAvailabilitys.Click += new System.EventHandler(this.buttonAvailability_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelHello.Location = new System.Drawing.Point(19, 103);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(67, 23);
            this.labelHello.TabIndex = 3;
            this.labelHello.Text = "Привет";
            // 
            // Logo
            // 
            this.Logo.Image = global::Auto_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(3, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(232, 88);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(241, 314);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenAvailabilitys);
            this.Controls.Add(this.buttonOpenCars);
            this.Controls.Add(this.buttonOpenFirms);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFirms;
        private System.Windows.Forms.Button buttonOpenCars;
        private System.Windows.Forms.Button buttonOpenAvailabilitys;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox Logo;
    }
}

