using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeganCounter.Core.Enums;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Context.EntityConfiguration
{
    public class MealConfiguration : BaseConfiguration<Meal>
    {
        public override void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.Property(m => m.MealType).HasMaxLength(20);


            base.Configure(builder);


            builder.HasData(new Meal { Id = 1,MealType = "Kahvaltı", CreatedDate = DateTime.Now, State = State.Created },
                            new Meal { Id = 2, MealType = "Öğle Yemeği", CreatedDate = DateTime.Now, State = State.Created },
                            new Meal { Id = 3, MealType = "Akşam Yemeği", CreatedDate = DateTime.Now, State = State.Created },
                            new Meal { Id = 4, MealType = "Ara Öğün", CreatedDate = DateTime.Now, State = State.Created });
        }
    }
}
