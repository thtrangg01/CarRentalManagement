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
    public partial class frmSearchCarContract : Form
    {
        public delegate void OnCarSelected(ContractDetail contractDetail);
        public OnCarSelected onCarSelected;
        public frmSearchCarContract(OnCarSelected onCarSelected)
        {
            InitializeComponent();
            contractDetailBindingSource.DataSource = new ContractDetailEntity()
            {
                StartDate = DateTime.Now,
            };
            cboRentalUnit.DataSource = Enum.GetValues(typeof(RentalUnit));
            cboRentalUnit.SelectedItem = RentalUnit.Hour;
            txtQty.Text = 1.ToString();

            GetData();
            this.onCarSelected = onCarSelected;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            async Task<bool> UserKeepsTyping()
            {
                string txt = txtSearch.Text;   // remember text
                await Task.Delay(500);        // wait some
                return txt != txtSearch.Text;  // return that text chaged or not
            }
            if (await UserKeepsTyping()) return;

            GetData();
        }

        private void dgvCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var car = carBindingSource.Current as Car;
            var contractDetail = contractDetailBindingSource.Current as ContractDetailEntity;

            contractDetail.Car = car.ToEntity();
            var contractDetailModel = contractDetail.ToModel();
            onCarSelected?.Invoke(contractDetailModel);
            DialogResult = DialogResult.OK;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            var qty = 1;
            try {
                qty = Convert.ToInt32(txtQty.Text);
            }
            catch (Exception)
            {
                qty = 1;
            }
            UpdateEndDate(qty);
        }

        private void UpdateEndDate(int qty)
        {
            if (cboRentalUnit.SelectedItem == null)
            {
                return;
            }
            var rentalUnit = (RentalUnit)cboRentalUnit.SelectedItem;

            if (contractDetailBindingSource == null)
            {
                return;
            }

            var contractDetail = contractDetailBindingSource.Current as ContractDetailEntity;
            contractDetail.StartDate = dtStartDate.Value;

            switch (rentalUnit)
            {
                case RentalUnit.Hour:
                    contractDetail.EndDate = contractDetail.StartDate.AddHours(qty);
                    break;
                case RentalUnit.Day:
                    contractDetail.EndDate = contractDetail.StartDate.AddDays(qty);
                    break;
                default:
                    break;
            }

            txtEndDate.Text = contractDetail.EndDate.ToString();
        }

        private void cboRentalUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qty = 1;
            try
            {
                qty = Convert.ToInt32(txtQty.Text);
            }
            catch (Exception)
            {
                qty = 1;
            }
            UpdateEndDate(qty);
        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            int qty;
            try
            {
                qty = Convert.ToInt32(txtQty.Text);
            }
            catch (Exception)
            {
                qty = 1;
            }
            UpdateEndDate(qty);
            GetData();
        }

        private void GetData()
        {
            var contractDetail = contractDetailBindingSource.Current as ContractDetailEntity;
            carBindingSource.DataSource = CarBUS.SearchCar(txtSearch.Text, contractDetail.StartDate, contractDetail.EndDate);
        }
    }
}
