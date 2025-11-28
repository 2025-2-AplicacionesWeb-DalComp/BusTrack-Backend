using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using BusTrack_center_API.Searchroutes.Domain.Model.Queries;
using BusTrack_center_API.Searchroutes.Domain.Repositories;
using BusTrack_center_API.Searchroutes.Domain.Services;

namespace BusTrack_center_API.Searchroutes.Application.Internal.QueryServices;

public class RutaQueryService(IRutaRepository rutaRepository): IRutaQueryService
{
    public async Task<Ruta?> Handle(GetRutaByIdQuery query)
    {
        return await rutaRepository.FindByIdAsync(query.Id);
    }

    public async Task<Ruta?> Handle(GetRutaByNameQuery query)
    {
        return await rutaRepository.FindByNameAsync(query.Name);
    }
}