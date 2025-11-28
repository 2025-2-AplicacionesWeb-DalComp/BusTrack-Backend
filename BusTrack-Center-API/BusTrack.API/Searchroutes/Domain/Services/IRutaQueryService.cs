using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using BusTrack_center_API.Searchroutes.Domain.Model.Queries;

namespace BusTrack_center_API.Searchroutes.Domain.Services;

public interface IRutaQueryService
{
    Task<Ruta?> Handle(GetRutaByIdQuery query);
    
    Task <Ruta?> Handle(GetRutaByNameQuery query);
}