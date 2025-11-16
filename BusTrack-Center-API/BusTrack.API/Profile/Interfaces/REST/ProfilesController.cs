using System.Net.Mime;
using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Query;
using ACME.LearningCenterPlatform.API.Profiles.Domain.Services;
using ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST.Resources;
using ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Profile endpoints")]
public class ProfilesController
(IProfileCommandService profileCommandService,
 IProfileQueryService profileQueryService) : ControllerBase
{
    [HttpGet]
    //... (Swagger attributes unchanged)
    public async Task<IActionResult> GetAllProfiles()
    {
        var profiles = await profileQueryService.Handle(new GetAllProfilesQuery());
        var profileResources = profiles
            .Select(ProfileResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(profileResources);
    }
    
    [HttpGet("{profileId:int}")]
    //... (Swagger attributes unchanged)
    public async Task<IActionResult> GetProfileById(int profileId)
    {
        var profile = await profileQueryService.Handle(new GetProfileByIdQuery(profileId));
        if (profile is null) return NotFound();
        var profileResource = ProfileResourceFromEntityAssembler.ToResourceFromEntity(profile);
        return Ok(profileResource);
    }

    [HttpPost]
    //... (Swagger attributes unchanged)
    public async Task<IActionResult> CreateProfile(CreateProfileResource resource)
    {
        var createProfileCommand = CreateProfileCommandFromResourceAssembler.ToCommandFromResource(resource);
        var profile = await profileCommandService.Handle(createProfileCommand);
        if (profile is null) return BadRequest();
        var profileResource = ProfileResourceFromEntityAssembler.ToResourceFromEntity(profile);
        return CreatedAtAction(nameof(GetProfileById), new { profileId = profile.Id }, profileResource);
    }

    [HttpPut("{profileId:int}")]
    [SwaggerOperation(
        Summary = "Update Profile",
        Description = "Update an existing Profile",
        OperationId = "UpdateProfile"
    )]
    [SwaggerResponse(200, "The profile was updated", typeof(ProfileResource))]
    [SwaggerResponse(400, "The profile could not be updated")]
    [SwaggerResponse(404, "The profile was not found")]
    public async Task<IActionResult> UpdateProfile(int profileId, [FromBody] UpdateProfileResource resource)
    {
        var updateProfileCommand = UpdateProfileCommandFromResourceAssembler.ToCommandFromResource(resource, profileId);
        var profile = await profileCommandService.Handle(updateProfileCommand);
        if (profile is null) return BadRequest();
        var profileResource = ProfileResourceFromEntityAssembler.ToResourceFromEntity(profile);
        return Ok(profileResource);
    }
}