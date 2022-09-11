using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "check_list_item")]
    public class CheckListItem : BaseEntity
    {
        public int CheckListId { get; set; }
        
        public bool IsChecked { get; set; }

        public string Content { get; set; }

        public CheckList CheckList { get; set; }

        public override string ToString()
        {
            return this.Content;
        }
    }
}
