using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.BaseEntities;

namespace VeganCounter.Entities
{
    public class Food : BaseEntity
    {
        public string FoodName { get; set; }
        public double ProteinValue { get; set; }
        public double FatValue { get; set; }
        public double CarboValue { get; set; }
        public double Kcal { get; set; }
        public int CategoryID { get; set; }
        public string? Picture { get; set; }
       public virtual ICollection<Meal> Meals { get; set; }
        public  ICollection<Category> Categories { get; set; }

        public Food()
        {
            Meals = new HashSet<Meal>();
            Categories = new HashSet<Category>();
        }
    }
}
