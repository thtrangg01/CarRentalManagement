using BUS.Model;
using CarRentalManagement.Utils;
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
    public partial class frmRentalPrice : Form
    {
        public frmRentalPrice(ContractDetail contractDetail)
        {
            InitializeComponent();
            contractDetailBindingSource.DataSource = contractDetail;

            lblCar.Text = $"{contractDetail.Number} - {contractDetail.CarName} ({contractDetail.LicensePlates})";
            lblRentalTime.Text = $"{contractDetail.StartDate.ToString("dd/MM/yyyy HH:mm")} - {contractDetail.EndDate.ToString("dd/MM/yyyy HH:mm")}";

            CalculateRentalPrice();

            var car = contractDetail.Car;
            var meterUnit = car.MeterUnit;

            if (contractDetail.HasFlatPriceOnly())
            {
                pnHourly.Visible = false;
                pnDaily.Visible = false;

                pnFlat.Visible = true;

                var flatPrice = contractDetail.RentalPriceQties.Find(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_FLAT_RATE);
                lblFlatRate.Text = TextUtils.FormatCurrencyVN(flatPrice.Rate);
            }
            else
            {
                pnFlat.Visible = false;
                if (contractDetail.HasHourPrice())
                {
                    pnHourly.Visible = true;
                    var hourPrice = contractDetail.RentalPriceQties.Find(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_HOUR);
                    lblHourly.Text = $"{hourPrice.Quantity} x Hàng giờ ({hourPrice.MeterLimit} {car.MeterUnit}) ";
                    lblHourRate.Text = TextUtils.FormatCurrencyVN(hourPrice.Rate * (decimal)hourPrice.Quantity);
                } else
                {
                    pnHourly.Visible = false;
                }

                if (contractDetail.HasDayPrice())
                {
                    pnDaily.Visible = true;
                    var dayPrice = contractDetail.RentalPriceQties.Find(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_DAY);
                    lblDaily.Text = $"{dayPrice.Quantity} x Hàng ngày ({dayPrice.MeterLimit * dayPrice.Quantity} {car.MeterUnit})";
                    lblDailyRate.Text = TextUtils.FormatCurrencyVN(dayPrice.Rate * (decimal)dayPrice.Quantity);
                } else
                {
                    pnDaily.Visible = false;
                }
            }

            //contractDetail.PropertyChanged += 

            lblSubtotal.Text = TextUtils.FormatCurrencyVN(contractDetail.Subtotal);
        }

        private void CalculateRentalPrice()
        {
            var contractDetail = contractDetailBindingSource.Current as ContractDetail;
            var car = contractDetail.Car;
            var rentalPrices = car.RentalPrices;

            var hasFlatPrice = rentalPrices.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_FLAT_RATE);

            if (hasFlatPrice)
            {
                var flatPrice = rentalPrices.Find(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_FLAT_RATE);
                var flatPriceQty = new RentalPriceQty()
                {
                    CarId = car.Id,
                    KeyCode = flatPrice.KeyCode,
                    Title = flatPrice.Title,
                    MeterLimit = flatPrice.MeterLimit,
                    Rate = flatPrice.Rate,
                    Quantity = 1,
                };

                if (contractDetail.RentalPriceQties == null)
                {
                    contractDetail.RentalPriceQties = new List<RentalPriceQty>();
                }


                contractDetail.RentalPriceQties.Add(flatPriceQty);
            }
            else
            {
                var hourBetween = (contractDetail.EndDate - contractDetail.StartDate).TotalHours;

                var dayNum = hourBetween / 24;
                if (dayNum < 1)
                {
                    var hourPrice = rentalPrices.Find(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_HOUR);
                    var hourPriceQty = new RentalPriceQty()
                    {
                        CarId = car.Id,
                        KeyCode = hourPrice.KeyCode,
                        Title = hourPrice.Title,
                        MeterLimit = hourPrice.MeterLimit,
                        Rate = hourPrice.Rate,
                        Quantity = hourBetween
                    };

                    if (contractDetail.RentalPriceQties == null)
                    {
                        contractDetail.RentalPriceQties = new List<RentalPriceQty>();
                    }
                    contractDetail.RentalPriceQties.Add(hourPriceQty);
                }
                else
                {
                    var dayBetween = (contractDetail.EndDate - contractDetail.StartDate).TotalDays;
                    var dayTruncate = System.Math.Truncate(dayBetween);

                    if (dayBetween - dayTruncate == 0)
                    {
                        var dayPrice = rentalPrices.Find(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_DAY);
                        var dayPriceQty = new RentalPriceQty()
                        {
                            CarId = car.Id,
                            KeyCode = dayPrice.KeyCode,
                            Title = dayPrice.Title,
                            MeterLimit = dayPrice.MeterLimit,
                            Rate = dayPrice.Rate,
                            Quantity = dayBetween
                        };

                        if (contractDetail.RentalPriceQties == null)
                        {
                            contractDetail.RentalPriceQties = new List<RentalPriceQty>();
                        }
                        contractDetail.RentalPriceQties.Add(dayPriceQty);
                    }
                    else
                    {
                        var hourPrice = rentalPrices.Find(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_HOUR);
                        var hourPriceQty = new RentalPriceQty()
                        {
                            CarId = car.Id,
                            KeyCode = hourPrice.KeyCode,
                            Title = hourPrice.Title,
                            MeterLimit = hourPrice.MeterLimit,
                            Rate = hourPrice.Rate,
                            Quantity = Math.Round((dayBetween - dayTruncate) * 24, 1)
                        };

                        var dayPrice = rentalPrices.Find(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_DAY);
                        var dayPriceQty = new RentalPriceQty()
                        {
                            CarId = car.Id,
                            KeyCode = dayPrice.KeyCode,
                            Title = dayPrice.Title,
                            MeterLimit = dayPrice.MeterLimit,
                            Rate = dayPrice.Rate,
                            Quantity = dayTruncate
                        };

                        if (contractDetail.RentalPriceQties == null)
                        {
                            contractDetail.RentalPriceQties = new List<RentalPriceQty>();
                        }
                        contractDetail.RentalPriceQties.Add(hourPriceQty);
                        contractDetail.RentalPriceQties.Add(dayPriceQty);
                    }

                }
            }

            contractDetail.CalculateSubtotal();
        }

        private void frmRentalPrice_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
