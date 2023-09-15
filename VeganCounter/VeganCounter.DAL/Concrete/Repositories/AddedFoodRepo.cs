﻿using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Base.EntityFramework;
using VeganCounter.DAL.Concrete.Context;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Repositories
{
    public class AddedFoodRepo : BaseRepository<AddedFood, VeganCounterDbContext>, IAddedFoodRepo
    {
        public AddedFoodRepo(VeganCounterDbContext contex) : base(contex)
        {
        }
    }
}
