using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeganCounter.Core.BaseEntities;

namespace VeganCounter.DAL.Concrete.Context.EntityConfiguration
{
    public abstract class AuditableConfiguration<TEntity> : BaseConfiguration<TEntity>
        where TEntity : AuditableEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.DeletedDate).IsRequired(false);

            base.Configure(builder);
        }
    }
}

