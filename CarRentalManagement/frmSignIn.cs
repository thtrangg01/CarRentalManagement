using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Domain;
using DAO;

namespace CarRentalManagement
{
    public partial class frmSignIn : Form
    {

        private AppDbContext appDbContext;
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;

            /*
            string selectFomat =
                "select * from SignIn where BINARY_CHECKSUM(Username) = BINARY_CHECKSUM('{0}') and BINARY_CHECKSUM(Password) = BINARY_CHECKSUM('{1}') ";

            string sql = String.Format(selectFomat, username, password);

            */
        
           

            if (logedIn(username, password))
            {

                frmMain main = new frmMain();
                this.Hide();
                main.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }

        
}

        bool logedIn(string username, string password)
        {
            
            return SignInDAO.Instance.Login(username, password);
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
