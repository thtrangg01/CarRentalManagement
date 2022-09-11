using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Model
{
    public class ContractDetail : BaseModel, INotifyPropertyChanged
    {
        public int CarId { get; set; }

        public string Number { get; set; }

        public string CarName { get; set; }

        public string LicensePlates { get; set; }

        public Car Car { get; set; }

        public int ContractId { get; set; }

        //public Contract Contract { get; set; }

        public DateTime PickUpDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int PickUpCheckListId { get; set; }
        public int ReturnCheckListId { get; set; }

        public List<RentalPriceQty> RentalPriceQties { get; set; }

        public bool CheckInDone { get; set; }
        public bool CheckOutDone { get; set; }

        public double RealMeter { get; set; }

        public double MeterLimit { get; set; }

        public double Overtime { get; set; }

        public decimal OvertimeRate { get; set; }

        public decimal Tax { get; set; }

        public double PercentTax { get; set; }

        public decimal Discount { get; set; }

        public double PercenDiscount { get; set; }
        public decimal Subtotal { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void CalculateSubtotal()
        {
            if (RentalPriceQties == null)
            {
                Subtotal = 0;
            }
            else
            {
                Subtotal = RentalPriceQties.Sum(rp => (rp.Rate * (decimal)rp.Quantity));
            }
        }

        public bool HasFlatPriceOnly()
        {
            return RentalPriceQties != null && RentalPriceQties.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_FLAT_RATE) && !(HasDayPrice() || HasHourPrice());
        }

        public bool HasHourPrice()
        {
            return RentalPriceQties != null && RentalPriceQties.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_HOUR);
        }

        public bool HasDayPrice()
        {
            return RentalPriceQties != null && RentalPriceQties.Any(rp => rp.KeyCode == RentalPriceKeyCode.RENTAL_PRICE_DAY);
        }
    }
}
