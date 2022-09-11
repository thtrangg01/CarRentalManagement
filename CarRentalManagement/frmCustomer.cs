using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using CarRentalManagement.Extensions;
using Domain.Entities;

namespace CarRentalManagement
{
    public partial class frmCustomer : Form
    {
        private int i = 1;
        public frmCustomer()
        {
            InitializeComponent();
            customerBindingSource.DataSource = CustomerBUS.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using frmAddEditCustomer frm = new frmAddEditCustomer(null);  
            if (frm.ShowDialog() == DialogResult.OK)
            {
                customerBindingSource.DataSource = CustomerBUS.GetAll();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (customerBindingSource.Current == null)
            {
                return;
            }

            var currentCustomer = customerBindingSource.Current as Customer;
            using frmAddEditCustomer frm = new frmAddEditCustomer(currentCustomer);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                customerBindingSource.DataSource = CustomerBUS.GetAll();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerBindingSource.Current == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CustomerBUS.Delete(customerBindingSource.Current as Customer);
                customerBindingSource.RemoveCurrent();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomers.SetupRowColor();
            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                var numberCell = row.Cells["Number"];
                numberCell.Style.ForeColor = Color.FromArgb(16, 68, 115);
            }
        }
    }
}
