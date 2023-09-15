using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganCounter.Core.BaseEntities
{
    /// <summary>
    /// Burdaki işlem tam silme işlemidirdir.
    /// </summary>
    public abstract class AuditableEntity:BaseEntity
    {
        public DateTime? DeletedDate { get; set; }
    }
}
