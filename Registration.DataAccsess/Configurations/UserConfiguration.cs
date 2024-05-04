using Microsoft.EntityFrameworkCore;
using Registration.DataAccsess.Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Registration.DataAccsess.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User> {
    public void Configure(EntityTypeBuilder<User> builder) {

        builder.Property(p => p.Age).IsRequired();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Email).IsRequired();
        builder.Property(p => p.Surname).IsRequired();
        builder.Property(p => p.Username).IsRequired();
        builder.Property(p => p.Password).IsRequired();
    }
}
