using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.BLL.Concrete.Mapper;
using VeganCounter.BLL.Concrete.Services;
using VeganCounter.DAL.Concrete;

namespace VeganCounter.BLL.Concrete
{
    public static class EfContextBll
    {
        public static IServiceCollection AddScopedBll(this IServiceCollection services)
        {
            services.AddScopedDal()
                .AddScoped<IAdminService, AdminService>()
                .AddScoped<IStandartUserService, StandartUserService>()
                .AddScoped<IFoodService, FoodService>()
                .AddScoped<IDailyMessageService, DailyMessageService>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Mapping());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
