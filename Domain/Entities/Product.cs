using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "product")]
    public class Product : BaseEntity
    {
        public Product()
        {
        }

        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(10), Column(TypeName = "varchar")]
        public string ProductCode { get; set; }

        public int YearOfManufacture { get; set; }

        [StringLength(20), Column(TypeName = "varchar")]
        public string BodyType { get; set; }

        [ForeignKey("ManufacturerId")]
        public Manufacturer Manufacturer { get; set; }

        public override string ToString()
        {
            return ProductCode;
        }
    }
}
