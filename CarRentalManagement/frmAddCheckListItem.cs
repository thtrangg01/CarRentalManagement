using BUS;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
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
    public partial class frmAddCheckListItem : Form
    {
        private CheckList checkList;
        public frmAddCheckListItem(CheckList checkList)
        {
            InitializeComponent();
            this.checkList = checkList;
            checkListItemBindingSource.DataSource = new CheckListItem();
        }

        private void frmAddCheckListItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                var checkListItem = checkListItemBindingSource.Current as CheckListItem;

                if (checkList.CheckListItems == null) {
                    checkList.CheckListItems = new List<CheckListItem>();
                }
                checkList.CheckListItems.Add(checkListItem);
            }
        }
    }
}
