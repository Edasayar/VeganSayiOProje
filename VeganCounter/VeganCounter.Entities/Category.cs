using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.BaseEntities;

namespace VeganCounter.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public int? FoodId { get; set; }
        public Food? Food { get; set; }
    }
}
