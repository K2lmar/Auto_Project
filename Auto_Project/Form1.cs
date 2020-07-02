using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "agent") buttonOpenAvailabilitys.Enabled = false;
            labelHello.Text = "Добро пожаловать, " + FormAuthorization.users.login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formFirm = new FormFirm();
            formFirm.Show();
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            Form formCar = new FormCar();
            formCar.Show();
        }

        private void buttonAvailability_Click(object sender, EventArgs e)
        {
            Form formAvailability = new FormAvailability();
            formAvailability.Show();
        }
    }
}
