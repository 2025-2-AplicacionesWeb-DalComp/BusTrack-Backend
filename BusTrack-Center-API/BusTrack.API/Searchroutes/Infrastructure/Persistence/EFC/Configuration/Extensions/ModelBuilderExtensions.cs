using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;
namespace BusTrack_center_API.Searchroutes.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyRutaConfiguration(this ModelBuilder modelBuilder)
    {
        // Category Entity Configuration
        modelBuilder.Entity<Ruta>().HasKey(r => r.Id);
        modelBuilder.Entity<Ruta>().Property(r=> r.Id).ValueGeneratedOnAdd().IsRequired();
        modelBuilder.Entity<Ruta>().Property(r => r.Name).IsRequired();
        modelBuilder.Entity<Ruta>().Property(r => r.Stop).IsRequired();
        modelBuilder.Entity<Ruta>().Property(r => r.EstimatedTime).IsRequired();
        modelBuilder.Entity<Ruta>().Property(r => r.Frequency).IsRequired();



    }
}