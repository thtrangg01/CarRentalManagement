using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RentalPriceQty : BaseEntity
    {
        public int CarId { get; set; }

        public int ContractId { get; set; }

        public string Title { get; set; }

        public double MeterLimit { get; set; }

        public RentalPriceKeyCode KeyCode { get; set; }

        public decimal Rate { get; set; }

        public double Quantity { get; set; }

        public ContractDetailEntity ContractDetailEntity { get; set; }
    }
}
