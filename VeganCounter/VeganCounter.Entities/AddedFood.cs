using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.BaseEntities;

namespace VeganCounter.Entities
{
    public class AddedFood : AppEntity
    {
        public int UserID { get; set; }
        public int FoodID { get; set; }
        public double CalculatedProtein { get; set; }
        public double CalculatedFat { get; set; }
        public double CalculatedCarbo { get; set; }
        public double CalculatedKcal { get; set; }
        public virtual ICollection<User>? Users { get; set; }

        public AddedFood()
        {
            Users = new HashSet<User>();
        }
    }
}
