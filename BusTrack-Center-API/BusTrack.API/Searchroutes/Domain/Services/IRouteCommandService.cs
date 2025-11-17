using BusTrack_center_API.Searchroutes.Domain.Model.Commands;
using Route = BusTrack_center_API.Searchroutes.Domain.Model.Aggregates.Route;

namespace BusTrack_center_API.Searchroutes.Domain.Services;

public interface IRouteCommandService
{
    Task<Route?> Handle(CreateRouteCommand command);
}