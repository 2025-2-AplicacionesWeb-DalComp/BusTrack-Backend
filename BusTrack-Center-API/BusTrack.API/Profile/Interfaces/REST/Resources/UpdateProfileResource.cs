namespace ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST.Resources;

/// <summary>
/// Resource for updating a profile.
/// </summary>
/// <param name="Username">The new username</param>
/// <param name="PhotoUrl">The new photo URL</param>
public record UpdateProfileResource(
    string Username,
    string PhotoUrl
);