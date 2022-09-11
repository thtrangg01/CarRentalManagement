using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "check_list")]
    public class CheckList: BaseEntity
    {
        public int? CarContractDetailId { get; set; }
        
        public int StaffId { get; set; }
        
        public DateTime Time { get; set; }
        
        public double? Meter { get; set; }

        public string Note { get; set; }

        public List<CheckListItem> CheckListItems { get; set; }
    }
}
