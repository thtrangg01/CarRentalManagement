using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "contract")]
    public class ContractEntity : BaseEntity
    {
        [Required]
        [StringLength(10), Column(TypeName = "varchar")]
        public string Number { get; set; }

        [Required]
        [StringLength(20), Column(TypeName = "varchar")]
        public string Status { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        public decimal? Discount { get; set; }

        public double? PercentDiscount { get; set; }

        public decimal? Tax { get; set; }

        public decimal? PercentTax { get; set; }

        public decimal Subtotal { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public string RentalAgreement { get; set; }

        public string RentalCondition { get; set; }

        public int? CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public Staff Creator { get; set; }

        public int? CompleteById { get; set; }

        [ForeignKey("CompleteById")]
        public Staff CompleteBy { get; set; }

        public List<ContractDetailEntity> ContractDetails { get; set; }
    }
}
