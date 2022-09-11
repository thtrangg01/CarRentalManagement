using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    [Table(name: "payment")]
    public class Payment: BaseEntity
    {
        public int contractId { get; set; }

        public decimal amount { get; set; }

        public string method { get; set; }

        public DateTime date { get; set; }




    }
}
