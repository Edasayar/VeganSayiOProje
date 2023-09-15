using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganCounter.Core.BaseEntities
{
    /// <summary>
    /// Base entityden kalırım verdik fakat aşağıdaki özellikleri burda tutmak istedik.Deleted olma nedeni user kaydı silse bile silme işlemi yaptı diye işaretleme yapacağız.Ama veritabanında bu sistemler tutulacak
    /// </summary>
    public abstract class AppEntity: BaseEntity
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
