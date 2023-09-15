using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Base.EntityFramework;
using VeganCounter.DAL.Concrete.Context;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Repositories
{
    public class MealRepo : BaseRepository<Meal, VeganCounterDbContext>, IMealRepo
    {
        public MealRepo(VeganCounterDbContext contex) : base(contex)
        {
        }
    }
}
