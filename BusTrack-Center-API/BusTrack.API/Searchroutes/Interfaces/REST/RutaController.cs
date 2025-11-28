using System.Net.Mime;
using BusTrack_center_API.Searchroutes.Application.Internal.CommandServices;
using BusTrack_center_API.Searchroutes.Interfaces.Resource;
using BusTrack_center_API.Searchroutes.Interfaces.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BusTrack_center_API.Searchroutes.Interfaces.REST;
[ApiController]
[Route("api/v1/Rutas")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Route Management")]

public class RutaController (RutaCommandService commandService): ControllerBase
{
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new route",
        Description = "Creates a new route",
        OperationId = "CreateRoute")]
    [SwaggerResponse(201, "Created", typeof(RutaResource))]
    [SwaggerResponse(400, "Bad Request", typeof(string))]
    public async Task<IActionResult> CreateRuta([FromBody] CreateRutaResource resource)
    {
        try
        {
            var command = CreateRutaCommandFromResourceAssembler.ToCommandFromResource(resource);
            var created = await commandService.Handle(command);
            
            if (created == null)
                return BadRequest("Could not create premium order.");
            var response= RutaResourceFromEntityAssembler.ToResourceFromEntity(created);
            return Ok(response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}