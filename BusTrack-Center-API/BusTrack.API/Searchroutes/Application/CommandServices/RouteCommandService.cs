using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using BusTrack_center_API.Searchroutes.Domain.Model.Commands;
using BusTrack_center_API.Searchroutes.Domain.Repositories;
using BusTrack_center_API.Searchroutes.Domain.Services;
using BusTrack_center_API.Shared.Domain.Repositories;
using Route = BusTrack_center_API.Searchroutes.Domain.Model.Aggregates.Route;

namespace BusTrack_center_API.Searchroutes.Application.CommandServices;

public class RouteCommandService(
    IRouteRepository routeRepository,
    IUnitOfWork unitOfWork
) : IRouteCommandService
{
    public async Task<Route?> Handle(CreateRouteCommand command)
    {
        var route = new Route(command);

        await routeRepository.AddAsync(route);
        await unitOfWork.CompleteAsync();

        return route;
    }
}