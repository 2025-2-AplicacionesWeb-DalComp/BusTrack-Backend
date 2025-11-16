using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Command;
using ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST.Resources;

namespace ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST.Transform;

public static class CreateProfileCommandFromResourceAssembler
{
    public static CreateProfileCommand ToCommandFromResource(CreateProfileResource resource)
    {
        return new CreateProfileCommand(
            resource.Username,
            resource.Email,
            resource.Password,
            resource.PhotoUrl
        );
    }
}