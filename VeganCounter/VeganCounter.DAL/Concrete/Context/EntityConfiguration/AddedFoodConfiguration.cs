using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Context.EntityConfiguration
{
    public class AddedFoodConfiguration : AppEntityConfiguration<AddedFood>
    {
        public override void Configure(EntityTypeBuilder<AddedFood> builder)
        {
            base.Configure(builder);
        }
    }
}
