using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Model
{
    public class Contract : BaseModel
    {
        public string Number { get; set; }
        public string Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentDate { get; set; }

        public decimal Discount { get; set; }

        public double PercentDiscount { get; set; }

        public decimal Tax { get; set; }

        public decimal Subtotal { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string RentalAgreement { get; set; }

        public string RentalCondition { get; set; }

        public int? CreatorId { get; set; }

        public Staff Creator { get; set; }

        public int? CompleteById { get; set; }

        public Staff CompleteBy { get; set; }

        public List<ContractDetail> ContractDetails { get; set; }
    }
}
