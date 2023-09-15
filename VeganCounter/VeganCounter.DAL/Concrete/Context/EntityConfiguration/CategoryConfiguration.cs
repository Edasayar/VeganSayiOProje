using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeganCounter.Core.Enums;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Context.EntityConfiguration
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {


            base.Configure(builder);


            builder.HasData(new Category { Id = 1, CategoryName = "Yemek", CreatedDate = DateTime.Now, State = State.Created },
                            new Category { Id = 2, CategoryName = "Şarküteri", CreatedDate = DateTime.Now, State = State.Created },
                            new Category { Id = 3, CategoryName = "Sebze", CreatedDate = DateTime.Now, State = State.Created },
                            new Category { Id = 4, CategoryName = "Meyve", CreatedDate = DateTime.Now, State = State.Created },
                            new Category { Id = 5, CategoryName = "İçecek", CreatedDate = DateTime.Now, State = State.Created },
                            new Category { Id = 6, CategoryName = "Salata", CreatedDate = DateTime.Now, State = State.Created },
                            new Category { Id = 7, CategoryName = "Tatlı", CreatedDate = DateTime.Now, State = State.Created });
        }
    }
}
