using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagement;
using BUS.Mapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;
using Domain.Enum;
using BUS.Model;

namespace CarRentalManagement
{
    public partial class frmCar : Form
    {
        public frmCar()
        {
            InitializeComponent();
            carWrapperBindingSource.DataSource = CarBUS.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditCar frm = new frmAddEditCar(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                carWrapperBindingSource.DataSource = CarBUS.GetAll();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var cell = row.Cells[e.ColumnIndex];
                    var value = cell.Value.ToString();
                    Enum.TryParse(value, out CarStatus status);

                    switch (status)
                    {
                        case CarStatus.Available:
                            cell.Style.ForeColor = Color.FromArgb(6, 189, 109);
                            break;
                        case CarStatus.Reserved:
                            cell.Style.ForeColor = Color.FromArgb(16, 68, 115);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var car = carWrapperBindingSource.Current as Car;
            frmAddEditCar frm = new frmAddEditCar(car);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                carWrapperBindingSource.DataSource = CarBUS.GetAll();
            } 
                
        }
    }
}
