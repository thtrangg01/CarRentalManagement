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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void lstStaff_Click(object sender, EventArgs e)
        {
            frmStaff lststaff = new frmStaff();
            lststaff.ShowDialog();
        }

        private void lstCar_Click(object sender, EventArgs e)
        {
            frmCar frmCar = new frmCar();
            frmCar.ShowDialog();
        }

        private void lstContract_Click(object sender, EventArgs e)
        {
            frmListContract frmListContract = new frmListContract();
            frmListContract.ShowDialog();
        }

        private void lstCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void mnuSignOut_Click(object sender, EventArgs e)
        {

        }
    }
}
