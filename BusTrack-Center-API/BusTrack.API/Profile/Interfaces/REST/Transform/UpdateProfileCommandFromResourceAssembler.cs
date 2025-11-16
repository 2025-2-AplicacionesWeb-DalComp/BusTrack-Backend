using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Command;
using ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST.Resources;

namespace ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST.Transform;

public static class UpdateProfileCommandFromResourceAssembler
{
    public static UpdateProfileCommand ToCommandFromResource(UpdateProfileResource resource, int profileId)
    {
        return new UpdateProfileCommand(
            profileId,
            resource.Username,
            resource.PhotoUrl
        );
    }
}