using BUS;
using BUS.Mapper;
using BUS.Model;
using CarRentalManagement.Utils;
using Domain;
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
    public partial class frmAddEditCar : Form
    {
        private bool isNew = false;
        public frmAddEditCar(Car obj)
        {
            InitializeComponent();

            txtCost.LostFocus += new EventHandler(textCost_LostFocus);

            using var db = new AppDbContext();
            manufacturerBindingSource.DataSource = db.Manufacturers.ToList();
            cboMeter.DataSource = Enum.GetValues(typeof(MeterUnit));

            if (obj == null)
            {
                carBindingSource.DataSource = new Car()
                {
                    Manufacturer = manufacturerBindingSource.Current as Manufacturer,
                    Product = productBindingSource.Current as Product,
                    RentalPrices = new List<RentalPrice>()
                };
                GenerateNumber();
                Text = "[Thêm mới] - Thông tin xe";
                isNew = true;
            }
            else
            {
                // 1 product belong to only 1 manufacturer
                carBindingSource.DataSource = obj;
                Text = "[Sửa] - Thông tin xe";
                productBindingSource.DataSource = obj.Product;
                manufacturerBindingSource.DataSource = obj.Product.Manufacturer;
                isNew = false;
            }

            var car = carBindingSource.Current as Car;
            //rentalPriceBindingSource.DataSource = car.RentalPrices;
        }

        private void cboManufacturer_SelectedValueChanged(object sender, EventArgs e)
        {
            var manufacturer = cboManufacturer.SelectedItem as Manufacturer;
            if (manufacturer == null) return;
            var selectedId = manufacturer.Id;

            using var db = new AppDbContext();
            var products = db.Products.ToList().FindAll(p => p.ManufacturerId == selectedId);
            productBindingSource.DataSource = products;
        }

        private void chbRequireCheckList_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = (sender as CheckBox).Checked;
            lblPickUpCheckList.Visible = isChecked;
            lblReturnCheckList.Visible = isChecked;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            var car = carBindingSource.Current as Car;
            Console.WriteLine(car.ToString());
        }

        private void lblPickUpCheckList_Click(object sender, EventArgs e)
        {
            var car = carBindingSource.Current as Car;
            var pickUpCheckList = car.PickUpCheckList;
            if (pickUpCheckList == null)
            {
                pickUpCheckList = new CheckList();
            }
            frmCheckList frm = new frmCheckList(pickUpCheckList);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                car.PickUpCheckList = pickUpCheckList;
            }
        }

        private void lblReturnCheckList_Click(object sender, EventArgs e)
        {
            var car = carBindingSource.Current as Car;
            var returnCheckList = car.ReturnCheckList;
            if (returnCheckList == null)
            {
                returnCheckList = new CheckList();
            }
            frmCheckList frm = new frmCheckList(returnCheckList);

            if(frm.ShowDialog() == DialogResult.OK)
            {
                car.ReturnCheckList = returnCheckList;
            }
        }

        private void frmAddEditCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtNumber.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã xe", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumber.Focus();
                    e.Cancel = true;
                    return;
                }

                var car = carBindingSource.Current as Car;
                if (car.RentalPrices == null || car.RentalPrices.Count == 0)
                {
                    MessageBox.Show("Vui lòng thiết lập ít nhất 1 loại giá thuê!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button2.Focus();
                    e.Cancel = true;
                    return;
                }

                var carEntity = car.ToEntity();
                if (isNew)
                {
                    CarBUS.Insert(carEntity);
                }
                else
                {
                    CarBUS.Update(carEntity);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var car = carBindingSource.Current as Car;
            //if (car.RentalPrices == null)
            //{
            //    car.RentalPrices = new List<RentalPrice>();
            //    rentalPriceBindingSource.DataSource = car.RentalPrices;
            //}

            //frmAddEditRentalPrice frm = new frmAddEditRentalPrice(car);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    rentalPriceBindingSource.ResetBindings(false);
            //}

            frmAddEditRentalPrice frm = new frmAddEditRentalPrice(car, AddRentalPrice);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                rentalPricesBindingSource.ResetBindings(false);
                //rentalPriceBindingSource.ResetBindings(false);
            }

        }

        private void textCost_LostFocus(object sender, EventArgs e)
        {
            //txtCost.Text = TextUtils.FormatCurrencyVN(Convert.ToDecimal(txtCost.Text));
        }

        private void GenerateNumber()
        {
            var car = CarBUS.GetLast();
            (carBindingSource.DataSource as Car).Number = TextUtils.GenerateId("CAR", car.Number);
            txtNumber.Enabled = false;
        }

        private void AddRentalPrice(RentalPrice rentalPrice)
        {
            var car = carBindingSource.Current as Car;
            if (car.RentalPrices == null)
            {
                car.RentalPrices = new List<RentalPrice>();
            }

            car.RentalPrices.Add(rentalPrice);
        }

        
    }
}
