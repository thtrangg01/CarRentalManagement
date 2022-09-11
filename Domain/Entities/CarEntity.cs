using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CarEntity : BaseEntity
    {
        [Required]
        [StringLength(10), Column(TypeName = "varchar")]
        public string Number { get; set; }

        [Required]
        [StringLength(20), Column(TypeName = "varchar")]
        public CarStatus Status { get; set; }

        [Required]
        public decimal Cost { get; set; }

        public double Meter { get; set; }

        [StringLength(10), Column(TypeName = "varchar")]
        public MeterUnit MeterUnit { get; set; }

        [StringLength(15), Column(TypeName = "varchar")]
        public string LicensePlates {get;set;}

        public int Year { get; set; }

        public bool RequireCheckList { get; set; }

        [Required]
        public bool InsuranceOn { get; set; }

        public int ProductId { get; set; }

        public int? PickUpCheckListId { get; set; }

        public int? ReturnCheckListId { get; set; }

        public decimal OvertimeRate { get; set; }

        public bool Resreved { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public virtual CheckList PickUpCheckList { get; set; }

        public virtual CheckList ReturnCheckList { get; set; }

        public List<RentalPrice> RentalPrices { get; set; }

        public List<ContractDetailEntity> ContractDetails { get; set; }
    }
}
