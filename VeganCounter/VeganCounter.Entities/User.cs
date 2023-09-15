using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.BaseEntities;
using VeganCounter.Core.Enums;

namespace VeganCounter.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
      
        public string Gender { get; set; }

        public DateTime BirthDay { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }

        public DailyMessage? DailyMessage { get; set; }
        public int? DailyMessageId { get; set; }
        public virtual ICollection<Meal>? Meals { get; set; }
        public virtual ICollection<AddedFood> AddedFoods { get; set; }
        public User()
        {
            Meals = new HashSet<Meal>();
            AddedFoods = new HashSet<AddedFood>();
        }
    }
}
