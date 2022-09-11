using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using CarRentalManagement.Extensions;
using Domain.Entities;

namespace CarRentalManagement
{
    public partial class frmManufacturer : Form
    {

        private int i = 1;
        public frmManufacturer()
        {
            InitializeComponent();
            manufacturerBindingSource.DataSource = ManufacturerBUS.GetAll();
        }

        private void frmManufacturer_Load(object sender, EventArgs e)
        {
            dgvManufacturers.SetupRowColor();
            foreach (DataGridViewRow row in dgvManufacturers.Rows)
            {
                var numberCell = row.Cells["Number"];
                numberCell.Style.ForeColor = Color.FromArgb(16, 68, 115);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using frmAddEditManufacturer frm = new frmAddEditManufacturer(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                manufacturerBindingSource.DataSource = ManufacturerBUS.GetAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (manufacturerBindingSource.Current == null)
            {
                return;
            }

            var currentManufacturer = manufacturerBindingSource.Current as Manufacturer;
            using frmAddEditManufacturer frm = new frmAddEditManufacturer(currentManufacturer);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                manufacturerBindingSource.DataSource = ManufacturerBUS.GetAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (manufacturerBindingSource.Current == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ManufacturerBUS.Delete(manufacturerBindingSource.Current as Manufacturer);
                manufacturerBindingSource.RemoveCurrent();
            }
        }
    }
}
