using Domain.Entities;
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
    public partial class frmCheckList : Form
    {
        private bool isNew = false;
        private CheckList checkList;
        public frmCheckList(CheckList checkList)
        {
            InitializeComponent();
            this.checkList = checkList;
            if (this.checkList.CheckListItems == null)
            {
                this.checkList.CheckListItems = new List<CheckListItem>();
            }

            checkListItemBindingSource.DataSource = this.checkList.CheckListItems;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCheckListItem f = new frmAddCheckListItem(checkList);
            if (f.ShowDialog() == DialogResult.OK)
            {
                checkListItemBindingSource.ResetBindings(false);
            }
        }

        private void frmCheckList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                
            }
        }
    }
}
