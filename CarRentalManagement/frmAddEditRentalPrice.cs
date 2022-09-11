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
    public delegate void OnSaveButtonClicked(RentalPrice rentalPrice);
    public partial class frmAddEditRentalPrice : Form
    {
        private Car car;
        private List<RentalPrice> rentalPrices;
        private OnSaveButtonClicked onSaveButtonClicked;
        public frmAddEditRentalPrice(Car car)
        {
            InitializeComponent();
            this.car = car;
            InitializeRentalPrice();
            rentalPriceBindingSource.DataSource = rentalPrices;
        }

        public frmAddEditRentalPrice(Car car, OnSaveButtonClicked onSaveButtonClicked)
        {
            InitializeComponent();
            this.car = car;
            this.onSaveButtonClicked = onSaveButtonClicked;

            InitializeRentalPrice();
        }

        private void InitializeRentalPrice()
        {
            if(rentalPrices == null)
            {
                rentalPrices = new List<RentalPrice>();
            }

            var hasFlatPrice = car.RentalPrices.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_FLAT_RATE);
            if (!hasFlatPrice)
            {
                var flatPrice = new RentalPrice()
                {
                    CarId = car.Id,
                    Title = "Đồng giá",
                    MeterLimit = 0,
                    KeyCode = RentalPriceKeyCode.RENTAL_FLAT_RATE,
                    Rate = 0
                };

                rentalPrices.Add(flatPrice);
            }

            var hasHourPrice = car.RentalPrices.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_HOUR);

            if (!hasHourPrice)
            {
                var hourPrice = new RentalPrice() {
                    CarId = car.Id,
                    Title = "Hàng giờ",
                    MeterLimit = 0,
                    KeyCode = RentalPriceKeyCode.RENTAL_PRICE_HOUR,
                    Rate = 0
                };

                rentalPrices.Add(hourPrice);
            }

            var hasDayPrice = car.RentalPrices.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_DAY);
            if (!hasDayPrice)
            {
                var dayPrice = new RentalPrice()
                {
                    CarId = car.Id,
                    Title = "Hàng ngày",
                    MeterLimit = 0,
                    KeyCode = RentalPriceKeyCode.RENTAL_PRICE_DAY,
                    Rate = 0
                };
                rentalPrices.Add(dayPrice);
            }

            //var hasMonthPrice = car.RentalPrices.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_MONTH);
            //if (!hasMonthPrice)
            //{
            //    var monthPrice = new RentalPrice()
            //    {
            //        CarId = car.Id,
            //        Title = "Hàng tháng",
            //        MeterLimit = 0,
            //        KeyCode = RentalPriceKeyCode.RENTAL_PRICE_MONTH,
            //        Rate = 0
            //    };
            //    rentalPrices.Add(monthPrice);
            //}

            //var hasWeekPrice = car.RentalPrices.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_WEEK);
            //if (!hasWeekPrice)
            //{
            //    var weekPrice = new RentalPrice()
            //    {
            //        CarId = car.Id,
            //        Title = "Hàng tuần",
            //        MeterLimit = 0,
            //        KeyCode = RentalPriceKeyCode.RENTAL_PRICE_WEEK,
            //        Rate = 0
            //    };
            //    rentalPrices.Add(weekPrice);
            //}

            //var otherPrice = new RentalPrice()
            //{
            //    CarId = car.Id,
            //    Title = "Label",
            //    MeterLimit = 0,
            //    KeyCode = RentalPriceKeyCode.RENTAL_PRICE_OTHER,
            //    Rate = 0
            //};
            //rentalPrices.Add(otherPrice);

            rentalPriceBindingSource.DataSource = rentalPrices;
        }

        private void cboTittle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbo = (ComboBox)sender;
            var selectedPrice = cbo.SelectedItem as RentalPrice;
            txtTitle.Visible = selectedPrice.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_OTHER;
        }

        private void frmAddEditRentalPrice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                var rentalPrice = rentalPriceBindingSource.Current as RentalPrice;
                onSaveButtonClicked?.Invoke(rentalPrice);
                //car.RentalPrices.Add(rentalPrice);
            }
        }
    }
}
