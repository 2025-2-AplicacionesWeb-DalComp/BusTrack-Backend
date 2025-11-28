using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using BusTrack_center_API.Searchroutes.Domain.Model.Commands;
using BusTrack_center_API.Searchroutes.Domain.Repositories;
using BusTrack_center_API.Searchroutes.Domain.Services;
using BusTrack_center_API.Shared.Domain.Repositories;

namespace BusTrack_center_API.Searchroutes.Application.Internal.CommandServices;

public class RutaCommandService(IRutaRepository rutaRepository, IUnitOfWork unitOfWork): IRutaCommandService
{
    public async Task<Ruta?> Handle(CreateRutaCommand command)
    {
        var rutaCreated = new Ruta(command);
        try
        {
            await rutaRepository.AddAsync(rutaCreated);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception ex)
        {
            return null;
        }

        return rutaCreated;
    }
}