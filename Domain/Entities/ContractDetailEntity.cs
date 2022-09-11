using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "contract_detail")]
    public class ContractDetailEntity : BaseEntity
    {
        public ContractDetailEntity()
        {
        }

        public int CarId { get; set; }

        public CarEntity Car { get; set; }

        public int ContractId { get; set; }

        public ContractEntity Contract { get; set; }

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

        public double PercenDiscount { get;set; }
        public decimal Subtotal { get; set; }
    }
}
