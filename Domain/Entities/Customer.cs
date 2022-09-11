using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("customer")]
    public class Customer : BaseEntity
    {
        [Required]
        [StringLength(10), Column(TypeName = "varchar")]
        public string Number { set; get; }

        [Required]
        [StringLength(100)]
        [DisplayName("Tên")]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày sinh")]
        public DateTime Dob { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(45)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string County { get; set; }

        public decimal Discount { get; set; }
    }
}
