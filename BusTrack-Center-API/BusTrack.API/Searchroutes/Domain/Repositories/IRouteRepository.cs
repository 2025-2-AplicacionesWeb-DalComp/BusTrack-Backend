using BusTrack_center_API.Shared.Domain.Repositories;

namespace BusTrack_center_API.Searchroutes.Domain.Repositories;

public interface IRouteRepository : IBaseRepository<Route>
{
    Task <IEnumerable<Route>> FindByNameAsync(string name );
    
    Task<bool> ExistsByNameAsync(string name);

    new Task AddAsync(Route route); 
}