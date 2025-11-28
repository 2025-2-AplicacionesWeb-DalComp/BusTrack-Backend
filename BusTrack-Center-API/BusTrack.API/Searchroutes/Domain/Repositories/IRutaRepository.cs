using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using BusTrack_center_API.Shared.Domain.Repositories;

namespace BusTrack_center_API.Searchroutes.Domain.Repositories;

public interface IRutaRepository: IBaseRepository<Ruta>
{
    Task<Ruta?> FindByNameAsync(string name);
}