using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaDeRestaurante.Entities;

namespace ReservaDeRestaurante.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        // Primary key
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id).UseMySqlIdentityColumn();

        builder.Property(u => u.Name).IsRequired();

        builder.Property(u => u.BirthDate).IsRequired();

        builder.Property(u => u.Phone).IsRequired();

        builder.Property(u => u.Email).IsRequired();
    }
}