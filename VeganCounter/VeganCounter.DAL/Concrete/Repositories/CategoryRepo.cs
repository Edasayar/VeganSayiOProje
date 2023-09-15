using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Base.EntityFramework;
using VeganCounter.DAL.Concrete.Context;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Repositories
{
    public class CategoryRepo:BaseRepository<Category, VeganCounterDbContext>, ICategoryRepo
    {
        public CategoryRepo(VeganCounterDbContext contex) : base(contex)
        {
        }
    }
}
