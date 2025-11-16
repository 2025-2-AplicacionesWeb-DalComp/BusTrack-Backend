using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Command;

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