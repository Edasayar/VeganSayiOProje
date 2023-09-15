using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.BaseEntities;

namespace VeganCounter.Entities
{
    public class DailyMessage : BaseEntity
    {
        public string MessageText { get; set; }

        public ICollection<User>? Users { get; set; }
        public DailyMessage()
        {
            Users = new HashSet<User>();
        }
    }
}
