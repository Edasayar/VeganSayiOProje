using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Base.EntityFramework;
using VeganCounter.DAL.Concrete.Context;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Repositories
{
    public class DailyMessageRepo : BaseRepository<DailyMessage, VeganCounterDbContext>, IDailyMessageRepo
    {
        public DailyMessageRepo(VeganCounterDbContext contex) : base(contex)
        {

        }
    }
}
