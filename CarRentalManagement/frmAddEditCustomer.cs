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
using Domain.Entities;

namespace CarRentalManagement
{
    public partial class frmAddEditCustomer : Form
    {
        private bool isNew = false;
        public frmAddEditCustomer(Customer obj)
        {
            InitializeComponent();

            if (obj == null)
            {
                customerBindingSource.DataSource = new Customer();
                pnContractHistory.Visible = false;
                this.Text = "[Thêm mới] - Thông tin khách hàng";
                isNew = true;
            } 
            else
            {
                customerBindingSource.DataSource = obj;
                pnContractHistory.Visible = true;
                this.Text = "[Sửa] - Thông tin khách hàng";
                isNew = false;
            }
        }

        private void frmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtCustomerNumber.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerNumber.Focus();
                    e.Cancel = true;
                    return;
                }

                var customer = customerBindingSource.Current as Customer;

                if(isNew)
                {
                    CustomerBUS.Insert(customer);
                } else
                {
                    CustomerBUS.Update(customer);
                }
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
