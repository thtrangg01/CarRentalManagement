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
    public partial class frmStaff : Form
    {

        private int i = 1;
        public frmStaff()
        {
            InitializeComponent();
            staffBindingSource.DataSource = StaffBUS.GetAll();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //dgvStaffs.SetupRowColor();
            //foreach (DataGridViewRow row in dgvStaffs.Rows)
            //{
            //    var numberCell = row.Cells["Number"];
            //    numberCell.Style.ForeColor = Color.FromArgb(16, 68, 115);
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using frmAddEditStaff frm = new frmAddEditStaff(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                staffBindingSource.DataSource = StaffBUS.GetAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (staffBindingSource.Current == null)
            {
                return;
            }

            var currentStaff = staffBindingSource.Current as Staff;
            using frmAddEditStaff frm = new frmAddEditStaff(currentStaff);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                staffBindingSource.DataSource = StaffBUS.GetAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (staffBindingSource.Current == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StaffBUS.Delete(staffBindingSource.Current as Staff);
                staffBindingSource.RemoveCurrent();
            }
        }
    }
}
