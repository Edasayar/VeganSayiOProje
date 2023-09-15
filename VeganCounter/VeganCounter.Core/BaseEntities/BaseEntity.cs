using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.Enums;

namespace VeganCounter.Core.BaseEntities
{
    /// <summary>
    /// Burda yapılan işlem ise gebşek silme anlamına gelir
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public State State { get; set; }
    }
}
