using BUS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagement
{
    public partial class frmListContract : Form
    {
        public frmListContract()
        {
            InitializeComponent();

            contractBindingSource.DataSource = ContractBUS.GetAll() ;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditContract frm = new frmAddEditContract();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //var contract = contractBindingSource.Current as Contract;
            //frmAddEditContract frm = new frmAddEditContract(contract);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    contractBindingSource.DataSource = ContractBUS.GetAll() ;
            //}
        }
    }
}
