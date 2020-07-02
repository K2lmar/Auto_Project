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
    public partial class FormFirm : Form
    {
        public FormFirm()
        {
            InitializeComponent();
            ShowFirm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FirmsSet firmSet = new FirmsSet();
            firmSet.NameCompany = textBoxNameCompany.Text;
            firmSet.Address = textBoxAddress.Text;
            firmSet.City = textBoxCity.Text;
            firmSet.Phone = textBoxPhone.Text;
            Program.wftDb.FirmsSet.Add(firmSet);
            Program.wftDb.SaveChanges();
            ShowFirm();
        }
        void ShowFirm()
        {
            listViewFirm.Items.Clear();
            foreach (FirmsSet firmSet in Program.wftDb.FirmsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  firmSet.Id.ToString(), firmSet.NameCompany, firmSet.Address,
                  firmSet.City, firmSet.Phone
                });
                item.Tag = firmSet;
                listViewFirm.Items.Add(item);
            }
            listViewFirm.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewFirm.SelectedItems.Count == 1)
            {
                FirmsSet firmSet = listViewFirm.SelectedItems[0].Tag as FirmsSet;
                firmSet.NameCompany = textBoxNameCompany.Text;
                firmSet.Address = textBoxAddress.Text;
                firmSet.City = textBoxCity.Text;
                firmSet.Phone = textBoxPhone.Text;
                Program.wftDb.SaveChanges();
                ShowFirm();
            }
        }

        private void listViewFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFirm.SelectedItems.Count == 1)
            {
                FirmsSet firmSet = listViewFirm.SelectedItems[0].Tag as FirmsSet;
                textBoxNameCompany.Text = firmSet.NameCompany;
                textBoxAddress.Text = firmSet.Address;
                textBoxCity.Text = firmSet.City;
                textBoxPhone.Text = firmSet.Phone;
            }
            else
            {
                textBoxNameCompany.Text = "";
                textBoxAddress.Text = "";
                textBoxCity.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            try
            {
                if (listViewFirm.SelectedItems.Count == 1)
                {
                    FirmsSet firmSet = listViewFirm.SelectedItems[0].Tag as FirmsSet;
                    Program.wftDb.FirmsSet.Remove(firmSet);
                    Program.wftDb.SaveChanges();
                    ShowFirm();
                }
                textBoxNameCompany.Text = "";
                textBoxAddress.Text = "";
                textBoxCity.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
