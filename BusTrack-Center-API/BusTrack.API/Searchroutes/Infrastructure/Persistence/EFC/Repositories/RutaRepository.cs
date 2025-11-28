using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using BusTrack_center_API.Searchroutes.Domain.Repositories;
using BusTrack_center_API.Shared.Infrastructure.Persistence.EFC.Configuration;
using BusTrack_center_API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BusTrack_center_API.Searchroutes.Infrastructure.Persistence.EFC.Repositories;

public class RutaRepository(AppDbContext context): BaseRepository<Ruta>(context), IRutaRepository 
{
    public async Task<Ruta?> FindByNameAsync(string name)
    {
        return await Context.Set<Ruta>()
            .FirstOrDefaultAsync(r => r.Name == name);
    }
}