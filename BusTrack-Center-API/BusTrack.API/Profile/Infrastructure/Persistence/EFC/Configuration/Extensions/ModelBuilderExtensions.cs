using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace ACME.LearningCenterPlatform.API.Profiles.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyProfilesConfiguration(this ModelBuilder builder)
    {
        // Profiles Context Configuration
        builder.Entity<Profile>().HasKey(p => p.Id);
        builder.Entity<Profile>().Property(p => p.Id).ValueGeneratedOnAdd().IsRequired();
        
        // Mapeo para Email (Value Object)
        builder.Entity<Profile>().OwnsOne(p => p.Email,
            e =>
            {
                e.WithOwner().HasForeignKey("Id");
                e.Property(p => p.Address).HasColumnName("EmailAddress");
            });

        // Mapeo para nuevos campos
        builder.Entity<Profile>().Property(p => p.Username).IsRequired();
        builder.Entity<Profile>().Property(p => p.PasswordHash).IsRequired();
        builder.Entity<Profile>().Property(p => p.PhotoUrl).IsRequired(false); // PhotoUrl es opcional
    }
}
