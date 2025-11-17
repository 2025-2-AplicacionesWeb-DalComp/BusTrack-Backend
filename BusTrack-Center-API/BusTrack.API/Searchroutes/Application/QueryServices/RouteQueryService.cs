using BusTrack_center_API.Searchroutes.Domain.Model.Queries;
using BusTrack_center_API.Searchroutes.Domain.Repositories;
using BusTrack_center_API.Searchroutes.Domain.Services;

namespace BusTrack_center_API.Searchroutes.Application.QueryServices;

public class RouteQueryService(IRouteRepository routeRepository) : IRouteQueryService
{
    public async Task<Route?> Handle(GetRouteByIdQuery query)
    {
        return await routeRepository.FindByIdAsync(query.RouteId);
    }

    public async Task<Route?> Handle(GetRouteByNameQuery query)
    {
        return await routeRepository.FindByNameAsync();
    }
}