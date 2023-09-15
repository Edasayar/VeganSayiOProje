using Microsoft.Extensions.DependencyInjection;
using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Concrete.Context;
using VeganCounter.DAL.Concrete.Repositories;

namespace VeganCounter.DAL.Concrete
{
    public static class EfContextDal
    {
        public static IServiceCollection AddScopedDal(this IServiceCollection services)
        {
            services.AddDbContext<VeganCounterDbContext>()
                    .AddScoped<IUserRepo, UserRepo>()
                    .AddScoped<IMealRepo, MealRepo>()
                    .AddScoped<IFoodRepo, FoodRepo>()
                    .AddScoped<ICategoryRepo, CategoryRepo>()
                    .AddScoped<IAddedFoodRepo, AddedFoodRepo>()
                    .AddScoped<IDailyMessageRepo, DailyMessageRepo>();

            return services;
        }
    }
}
