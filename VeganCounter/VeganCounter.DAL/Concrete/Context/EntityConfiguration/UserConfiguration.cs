using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.Enums;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Context.EntityConfiguration
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.UserName)
                   .IsRequired();

            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(e => e.Email).IsRequired();

            builder.Property(x => x.Password).IsRequired();

            builder.Property(x => x.Role).IsRequired().HasConversion(new EnumToStringConverter<Role>());

            builder.Property(x => x.Gender).IsRequired();

            builder.Property(x => x.BirthDay).IsRequired();


            base.Configure(builder);


            builder.HasData(new User { Id = 1, UserName = "Admin", Password = "Admin", Role = Role.Admin, Email = "admin@admin.com", Gender = "Male", BirthDay = new                                 DateTime(1990, 11, 27), CreatedDate = DateTime.Now, State = State.Created },
                            new User { Id = 2, UserName = "User1", Password = "User1.", Role = Role.StandartUser, Email = "user1@user.com", Gender = "Female", BirthDay = new          DateTime(1990, 11, 27), CreatedDate = DateTime.Now, State = State.Created },
                            new User { Id = 3, UserName = "User2", Password = "User2.", Role = Role.StandartUser, Email = "user2@user.com", Gender = "Female", BirthDay = new DateTime(1990, 11, 27), CreatedDate = DateTime.Now, State = State.Created },
                            new User { Id = 4, UserName = "User3", Password = "User3.", Role = Role.StandartUser, Email = "user3@user.com", Gender = "Female", BirthDay = new DateTime(1990, 11, 27), CreatedDate = DateTime.Now, State = State.Created },
                            new User { Id = 5, UserName = "User4", Password = "User4.", Role = Role.StandartUser, Email = "user4@user.com", Gender = "Female", BirthDay = new DateTime(1990, 11, 27), CreatedDate = DateTime.Now, State = State.Created },
                            new User { Id = 6, UserName = "User5", Password = "User5.", Role = Role.StandartUser, Email = "user5@user.com", Gender = "Female", BirthDay = new DateTime(1990, 11, 27), CreatedDate = DateTime.Now, State = State.Created });
        }
    }
}