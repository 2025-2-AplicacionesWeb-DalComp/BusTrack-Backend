using BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;
using BusTrack_center_API.Searchroutes.Interfaces.Resource;

namespace BusTrack_center_API.Searchroutes.Interfaces.Transform;

public static class RutaResourceFromEntityAssembler
{
    public static RutaResource ToResourceFromEntity(Ruta entity) =>
    new RutaResource(entity.Id, entity.Name, entity.Stop, entity.EstimatedTime, entity.Frequency);
    
    
}