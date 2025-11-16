namespace ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Command;

/// <summary>
/// Command to update a profile.
/// </summary>
/// <param name="ProfileId">The ID of the profile to update</param>
/// <param name="Username">The new username</param>
/// <param name="PhotoUrl">The new photo URL</param>
public record UpdateProfileCommand(
    int ProfileId,
    string Username,
    string PhotoUrl);