using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.BaseEntities;

namespace VeganCounter.Entities
{
    public class Meal : BaseEntity
    {
        public string MealType { get; set; }
       
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Food> Foods { get; set; }

        public Meal()
        {
            Users = new HashSet<User>();
            Foods = new HashSet<Food>();
        }
    }
}
