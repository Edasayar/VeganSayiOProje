using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Base.EntityFramework;
using VeganCounter.DAL.Concrete.Context;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Repositories
{
    public class FoodRepo : BaseRepository<Food, VeganCounterDbContext>, IFoodRepo
    {
        public FoodRepo(VeganCounterDbContext contex) : base(contex)
        {
        }
    }
}
