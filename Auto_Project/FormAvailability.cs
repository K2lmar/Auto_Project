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
    public partial class FormAvailability : Form
    {
        public FormAvailability()
        {
            InitializeComponent();
            ShowCar();
            ShowFirm();
            ShowAvailability();
        }

        void ShowCar()
        {
            comboBoxIdCars.Items.Clear();
            foreach (CarsSet carSet in Program.wftDb.CarsSet)
            {
                string[] item = {carSet.Id.ToString() + ".", carSet.ModelCar, carSet.Color.ToString(),
                  carSet.Price.ToString(), carSet.StateNumber, carSet.ReleaseYear };
                comboBoxIdCars.Items.Add(string.Join("", item));
            }
        }

        void ShowFirm()
        {
            comboBoxIdFirms.Items.Clear();
            foreach (FirmsSet firmSet in Program.wftDb.FirmsSet)
            {
                string[] item = {firmSet.Id.ToString() + ".", firmSet.NameCompany, firmSet.Address,
                  firmSet.City, firmSet.Phone };
                comboBoxIdFirms.Items.Add(string.Join("", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdCars.SelectedItem != null && comboBoxIdFirms.SelectedItem != null)
            {
                AvailabilitysSet availabilitySet = new AvailabilitysSet();
                availabilitySet.IdCars = Convert.ToInt32(comboBoxIdCars.SelectedItem.ToString().Split('.')[0]);
                availabilitySet.IdFirms = Convert.ToInt32(comboBoxIdFirms.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.AvailabilitysSet.Add(availabilitySet);
                Program.wftDb.SaveChanges();
                ShowAvailability();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowAvailability()
        {
            listViewAvailability.Items.Clear();
            foreach (AvailabilitysSet availabilitySet in Program.wftDb.AvailabilitysSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    availabilitySet.Id.ToString() + ".",
                    availabilitySet.IdCars.ToString(),
                    availabilitySet.CarsSet.ModelCar+" "+availabilitySet.CarsSet.Color+" "+availabilitySet.CarsSet.Price+" "+availabilitySet.CarsSet.StateNumber+" "+availabilitySet.CarsSet.ReleaseYear ,
                    availabilitySet.IdFirms.ToString() + ".",
                    availabilitySet.FirmsSet.NameCompany+" "+availabilitySet.FirmsSet.Address+" "+availabilitySet.FirmsSet.City+" "+availabilitySet.FirmsSet.Phone
                });
                item.Tag = availabilitySet;
                listViewAvailability.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                AvailabilitysSet availabilitySet = listViewAvailability.SelectedItems[0].Tag as AvailabilitysSet;
                availabilitySet.IdCars = Convert.ToInt32(comboBoxIdCars.SelectedItem.ToString().Split('.')[0]);
                availabilitySet.IdFirms = Convert.ToInt32(comboBoxIdFirms.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.SaveChanges();
                ShowAvailability();
            }
        }

        private void listViewAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                AvailabilitysSet availabilitySet = listViewAvailability.SelectedItems[0].Tag as AvailabilitysSet;
                comboBoxIdCars.SelectedIndex = comboBoxIdCars.FindString(availabilitySet.IdCars.ToString());
                comboBoxIdFirms.SelectedIndex = comboBoxIdFirms.FindString(availabilitySet.IdFirms.ToString());
            }
            else
            {
                comboBoxIdCars.SelectedItem = null;
                comboBoxIdFirms.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAvailability.SelectedItems.Count == 1)
                {
                    AvailabilitysSet availabilitySet = listViewAvailability.SelectedItems[0].Tag as AvailabilitysSet;
                    Program.wftDb.AvailabilitysSet.Remove(availabilitySet);
                    Program.wftDb.SaveChanges();
                    ShowAvailability();
                }
                comboBoxIdCars.SelectedItem = null;
                comboBoxIdFirms.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
