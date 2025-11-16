using BusTrack.API.Profiles.Domain.Model.Aggregates; // si no funciona usen al inicio using BusTrack_center_API
using BusTrack.API.Profiles.Domain.Model.Command;

namespace ACME.LearningCenterPlatform.API.Profiles.Domain.Services;
/// <summary>
///     Profile Command Service Interface
/// </summary>
public interface IProfileCommandService
{
    /// <summary>
    ///     Handle Create Profile Command
    /// </summary>
    Task<Profile?> Handle(CreateProfileCommand command);
    
    /// <summary>
    ///     Handle Update Profile Command
    /// </summary>
    Task<Profile?> Handle(UpdateProfileCommand command);
}
