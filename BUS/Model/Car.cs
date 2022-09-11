using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Model
{
    public class Car : BaseModel
    {
        public Car()
        {
        }

        public string Number { get; set; }
        public CarStatus Status { get; set; }
        public decimal Cost { get; set; }
        public double Meter { get; set; }
        public MeterUnit MeterUnit { get; set; }
        public bool InsuranceOn { get; set; }
        public int? PickUpCheckListId { get; set; }
        public int? ReturnCheckListId { get; set; }
        public decimal OvertimeRate { get; set; }
        public bool Resreved { get; set; }
        public string LicensePlates { get; set; }
        public int Year { get; set; }
        public bool RequireCheckList { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public virtual CheckList PickUpCheckList { get; set; }

        public virtual CheckList ReturnCheckList { get; set; }

        public List<RentalPrice> RentalPrices { get; set; }

        public List<ContractDetail> ContractDetails { get; set; }
    }
}
