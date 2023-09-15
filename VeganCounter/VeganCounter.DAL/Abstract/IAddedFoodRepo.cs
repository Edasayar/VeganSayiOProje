using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.IBaseRepositories;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Abstract
{
    public interface IAddedFoodRepo : IBaseRepository<AddedFood>
    {
    }
}

