using Microsoft.EntityFrameworkCore;

namespace BusTrack_center_API.Searchroutes.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyRoutesConfiguration(this ModelBuilder modelBuilder)
    {
        // Category Entity Configuration
        modelBuilder.Entity<Route>().HasKey(c => c.Id);
        modelBuilder.Entity<Route>().Property(c => c.Name).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Route>().Property(c => c.EstimatedTime).IsRequired();
        modelBuilder.Entity<Route>().Property(c => c.Frequency).IsRequired();
        
        
        







    }
}