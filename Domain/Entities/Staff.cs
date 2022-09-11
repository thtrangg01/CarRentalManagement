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
    [Table("staff")]
    public class Staff : BaseEntity
    {
        [Required]
        [StringLength(10), Column(TypeName = "varchar")]
        [DisplayName("Mã nhân viên")]
        public string StaffNumber { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Họ tên")]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày sinh")]
        public DateTime Dob { get; set; }

        [StringLength(20), Column(TypeName = "varchar")]
        [DisplayName("Điện thoại")]
        public string Phone { get; set; }

        [StringLength(20), Column(TypeName = "varchar")]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("Thành phố")]
        public string City { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("Quận/ huyện")]
        public string County { get; set; }

        public int ManagerId { get; set; }

        public SignIn SignIn { get; set; }
    }
}
