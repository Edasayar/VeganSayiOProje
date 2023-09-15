using Microsoft.EntityFrameworkCore;
using VeganCounter.DAL.Concrete.Context.EntityConfiguration;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Context
{
    public class VeganCounterDbContext:DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<AddedFood> AddedFoods { get; set; }
        public virtual DbSet<DailyMessage> DailyMessages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "data source=EDA\\MSSQLSERVER01;initial catalog=VeganSayiO;integrated security=True;MultipleActiveResultSets=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Meals)
                .WithMany(u => u.Users)
                .UsingEntity(u => u.ToTable("UserMeals"));
            modelBuilder.Entity<Meal>()
                .HasMany(u => u.Foods)
                .WithMany(u => u.Meals)
                .UsingEntity(u => u.ToTable("MealFoods"));
            modelBuilder.Entity<User>()
                .HasMany(u => u.AddedFoods)
                .WithMany(u => u.Users)
                .UsingEntity(u => u.ToTable("UserAddedFoods"));

            modelBuilder.Entity<DailyMessage>()
                .HasMany(x => x.Users)
                .WithOne(x => x.DailyMessage)
                .HasForeignKey(x => x.DailyMessageId);

            modelBuilder.Entity<Food>()
                .HasMany(x => x.Categories)
                .WithOne(x => x.Food)
                .HasForeignKey(x => x.FoodId);

            modelBuilder.ApplyConfiguration(new UserConfiguration())
                        .ApplyConfiguration(new MealConfiguration())
                        .ApplyConfiguration(new FoodConfiguration())
                        .ApplyConfiguration(new CategoryConfiguration())
                        .ApplyConfiguration(new AddedFoodConfiguration())
                        .ApplyConfiguration(new DailyMessageConfiguration());
        }
    }
}
