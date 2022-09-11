using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Model
{
    public class BaseModel
    {
        public int Id { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAd { get; set; }
    }
}
