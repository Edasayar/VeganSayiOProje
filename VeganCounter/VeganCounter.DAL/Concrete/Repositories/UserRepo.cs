using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Base.EntityFramework;
using VeganCounter.DAL.Concrete.Context;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Repositories
{
    public class UserRepo : BaseRepository<User, VeganCounterDbContext>, IUserRepo
    {
        public UserRepo(VeganCounterDbContext contex) : base(contex)
        {
        }
    }
}
