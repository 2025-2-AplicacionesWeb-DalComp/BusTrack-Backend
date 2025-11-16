namespace BusTrack.API.Profiles.Domain.Model.Command; // si no funciona usen al inicio using BusTrack_center_API

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
