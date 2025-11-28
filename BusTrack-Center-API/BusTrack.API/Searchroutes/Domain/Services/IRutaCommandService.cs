using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using BusTrack_center_API.Searchroutes.Domain.Model.Commands;

namespace BusTrack_center_API.Searchroutes.Domain.Services;

public interface IRutaCommandService
{
    Task<Ruta?> Handle(CreateRutaCommand command);
}