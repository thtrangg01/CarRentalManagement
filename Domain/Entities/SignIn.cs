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
    [Table("sign_in")]
    public class SignIn : BaseEntity
    {
        [Required]
        [StringLength(50), Column(TypeName = "varchar")]
        public string Username { get; set; }

        [Required]
        [StringLength(50), Column(TypeName = "varchar")]
        public string Password { get; set; }

        public int StaffId { get; set; }

        public Staff Staff { get; set; }
    }
}
