using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeganCounter.Core.Enums;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Context.EntityConfiguration
{
    public class DailyMessageConfiguration : BaseConfiguration<DailyMessage>
    {
        public override void Configure(EntityTypeBuilder<DailyMessage> builder)
        {
           base.Configure(builder);

            builder.HasData(new DailyMessage { Id = 1, MessageText = "Mesaj 1", CreatedDate = DateTime.Now, State = State.Created },
                            new DailyMessage { Id = 2, MessageText = "Mesaj 2", CreatedDate = DateTime.Now, State = State.Created },
                            new DailyMessage { Id = 3, MessageText = "Mesaj 3", CreatedDate = DateTime.Now, State = State.Created },
                            new DailyMessage { Id = 4, MessageText = "Mesaj 4", CreatedDate = DateTime.Now, State = State.Created },
                            new DailyMessage { Id = 5, MessageText = "Mesaj 5", CreatedDate = DateTime.Now, State = State.Created },
                            new DailyMessage { Id = 6, MessageText = "Mesaj 6", CreatedDate = DateTime.Now, State = State.Created },
                            new DailyMessage { Id = 7, MessageText = "Mesaj 7", CreatedDate = DateTime.Now, State = State.Created },
                            new DailyMessage { Id = 8, MessageText = "Mesaj 8", CreatedDate = DateTime.Now, State = State.Created });
        }
    }
}
