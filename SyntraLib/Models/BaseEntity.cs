using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    public class BaseEntity
    {
        // typ prop TAB TAB
        public int ID { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        // DateTime? betekent dat het null mag zijn

        public DateTime? DeletedAt { get; set; }

        public BaseEntity()
        {
            CreatedAt = ModifiedAt = DateTime.Now;
        }
            
    }
}
