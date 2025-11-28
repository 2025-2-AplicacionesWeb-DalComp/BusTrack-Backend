using BusTrack_center_API.Searchroutes.Domain.Model.Commands;
using BusTrack_center_API.Searchroutes.Interfaces.Resource;

namespace BusTrack_center_API.Searchroutes.Interfaces.Transform;

public static class CreateRutaCommandFromResourceAssembler
{
    public static CreateRutaCommand ToCommandFromResource(this CreateRutaResource resource)
    {
        if (resource == null)
        {
            throw new ArgumentNullException(nameof(resource), "Resource cannot be null");
        }
        
        return new CreateRutaCommand(
            resource.Name,
            resource.Stop,
            resource.EstimatedTime,
            resource.Frequency
        );
    }
}