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
    public partial class FormCar : Form
    {
        public FormCar()
        {
            InitializeComponent();
            ShowCar();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CarsSet carSet = new CarsSet();
            carSet.ModelCar = textBoxModelCar.Text;
            carSet.Color = Convert.ToInt32(comboBoxColor.Text);
            carSet.Price = Convert.ToInt32(textBoxPrice.Text);
            carSet.StateNumber = textBoxStateNumber.Text;
            carSet.ReleaseYear = textBoxReleaseYear.Text;
            Program.wftDb.CarsSet.Add(carSet);
            Program.wftDb.SaveChanges();
            ShowCar();
        }
        void ShowCar()
        {
            listViewCar.Items.Clear();
            foreach (CarsSet carSet in Program.wftDb.CarsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  carSet.Id.ToString(), carSet.ModelCar, carSet.Color.ToString(),
                  carSet.Price.ToString(), carSet.StateNumber, carSet.ReleaseYear
                });
                item.Tag = carSet;
                listViewCar.Items.Add(item);
            }
            listViewCar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 1)
            {
                CarsSet carSet = listViewCar.SelectedItems[0].Tag as CarsSet;
                carSet.ModelCar = textBoxModelCar.Text;
                carSet.Color = Convert.ToInt32(comboBoxColor.Text);
                carSet.Price = Convert.ToInt32(textBoxPrice.Text);
                carSet.StateNumber = textBoxStateNumber.Text;
                carSet.ReleaseYear = textBoxReleaseYear.Text;
                Program.wftDb.SaveChanges();
                ShowCar();
            }
        }

        private void listViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 1)
            {
                CarsSet carSet = listViewCar.SelectedItems[0].Tag as CarsSet;
                textBoxModelCar.Text = carSet.ModelCar;
                comboBoxColor.Text = carSet.Color.ToString();
                textBoxPrice.Text = carSet.Price.ToString();
                textBoxStateNumber.Text = carSet.StateNumber;
                textBoxReleaseYear.Text = carSet.ReleaseYear;
            }
            else
            {
                textBoxModelCar.Text = "";
                comboBoxColor.Text = "";
                textBoxPrice.Text = "";
                textBoxStateNumber.Text = "";
                textBoxReleaseYear.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCar.SelectedItems.Count == 1)
                {
                    CarsSet carSet = listViewCar.SelectedItems[0].Tag as CarsSet;
                    Program.wftDb.CarsSet.Remove(carSet);
                    Program.wftDb.SaveChanges();
                    ShowCar();
                }
                textBoxModelCar.Text = "";
                comboBoxColor.Text = "";
                textBoxPrice.Text = "";
                textBoxStateNumber.Text = "";
                textBoxReleaseYear.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
