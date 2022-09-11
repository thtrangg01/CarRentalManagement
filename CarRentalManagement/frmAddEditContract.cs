using BUS;
using BUS.Mapper;
using BUS.Model;
using Domain.Entities;
using Domain.Enum;
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
    public partial class frmAddEditContract : Form
    {
        private ContractDetail contractDetail;
        public frmAddEditContract()
        {
            InitializeComponent();
            contractBindingSource.DataSource = new Contract()
            {
                ContractDetails = new List<ContractDetail>()
            };

            var contract = contractBindingSource.Current as Contract;

            // Start hardCode Test Data
            contract.CreatorId = 15;
            contract.CustomerId = 1;
            var staff = StaffBUS.GetById((int)contract.CreatorId);
            var customer = CustomerBUS.GetById(contract.CustomerId);
            contract.Creator = staff;
            contract.Customer = customer;
            // End hardcode

            contractDetailBindingSource.DataSource = contract.ContractDetails.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchCarContract frm = new frmSearchCarContract(OnCarSelected);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (contractDetail == null) return;

                frmRentalPrice frmRentalPrice = new frmRentalPrice(contractDetail);

                if (frmRentalPrice.ShowDialog() == DialogResult.OK)
                {
                    var contract = contractBindingSource.Current as Contract;
                    contract.ContractDetails.Add(contractDetail);
                    contractDetailBindingSource.DataSource = contract.ContractDetails;
                } else
                {
                    contractDetail = null;
                }
            }
        }

        private void OnCarSelected(ContractDetail contractDetail)
        {
            this.contractDetail = contractDetail;
            //var contract = contractBindingSource.Current as Contract;
            //
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var contract = contractBindingSource.Current as Contract;
            contract.Status = "PENDING";
            ContractBUS.Insert(contract);

        }
    }
}
