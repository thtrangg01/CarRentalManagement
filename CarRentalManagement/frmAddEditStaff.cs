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
    public partial class frmAddEditStaff : Form
    {
        private bool isNew = false;
        public frmAddEditStaff(Staff obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                staffBindingSource.DataSource = new Staff();
                pnStaffManage.Visible = false;
                this.Text = "Thêm mới nhân viên";
                isNew = true;
            }
            else
            {
                staffBindingSource.DataSource = obj;
                pnStaffManage.Visible = true;
                this.Text = "Chỉnh sửa thông tin nhân viên";
                isNew = false;
            }
        }

        private void frmAddEditStaff_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void frmAddEditStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtStaffNumber.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStaffNumber.Focus();
                    e.Cancel = true;
                    return;
                }

                var staff = staffBindingSource.Current as Staff;

                if (isNew)
                {
                    StaffBUS.Insert(staff);
                }
                else
                {
                    StaffBUS.Update(staff);
                }
            }
        }
    }
}
