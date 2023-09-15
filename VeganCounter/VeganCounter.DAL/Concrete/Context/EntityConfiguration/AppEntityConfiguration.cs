using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeganCounter.Core.BaseEntities;

namespace VeganCounter.DAL.Concrete.Context.EntityConfiguration
{
    public abstract class AppEntityConfiguration<TEntity> : BaseConfiguration<TEntity>
        where TEntity : AppEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.CreatedBy).IsRequired(false);

            builder.Property(x => x.UpdatedBy).IsRequired(false);

            base.Configure(builder);
        }
    }
}
