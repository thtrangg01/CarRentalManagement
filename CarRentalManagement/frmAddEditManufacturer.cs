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
using Domain;
using Domain.Entities;

namespace CarRentalManagement
{
    public partial class frmAddEditManufacturer : Form
    {
        private bool isNew = false;
        public frmAddEditManufacturer(Manufacturer obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                manufacturerBindingSource.DataSource = new Staff();
                this.Text = "Thêm mới hãng sản xuất";
                isNew = true;
            }
            else
            {
                manufacturerBindingSource.DataSource = obj;
                this.Text = "Chỉnh sửa thông tin hãng sản xuất";
                isNew = false;
            }
        }

        private void frmAddEditManufacturer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtManufacturerName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên hãng sản xuất", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtManufacturerName.Focus();
                    e.Cancel = true;
                    return;
                }

                var manufacturer = manufacturerBindingSource.Current as Manufacturer;

                if (isNew)
                {
                    ManufacturerBUS.Insert(manufacturer);
                }
                else
                {
                    ManufacturerBUS.Update(manufacturer);
                }
            }
        }

            private void frmAddEditManufacturer_Load(object sender, EventArgs e)
            {
                this.AutoSize = true;
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }
    } 
}
