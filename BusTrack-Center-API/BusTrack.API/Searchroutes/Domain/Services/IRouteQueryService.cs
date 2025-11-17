using BusTrack_center_API.Searchroutes.Domain.Model.Commands;
using BusTrack_center_API.Searchroutes.Domain.Model.Queries;

namespace BusTrack_center_API.Searchroutes.Domain.Services;

public interface IRouteQueryService
{
    Task <Route?> Handle(GetRouteByIdQuery query);
    
    Task <Route?> Handle(GetRouteByNameQuery query);
}