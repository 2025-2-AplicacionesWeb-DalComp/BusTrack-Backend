using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.ValueObjects;
using ACME.LearningCenterPlatform.API.Shared.Domain.Repositories;

namespace ACME.LearningCenterPlatform.API.Profiles.Domain.Repositories;
/// <summary>
///     Profile repository interface
/// </summary>
public interface IProfileRepository : IBaseRepository<Profile>
{
    /// <summary>
    ///     Find profile by email
    /// </summary>
    /// <param name="email">
    ///     The <see cref="EmailAddress"/> email to search for
    /// </param>
    /// <returns>
    ///     The <see cref="Profile"/> if found, otherwise null
    /// </returns>
    Task<Profile?> FindProfileByEmailAsync(EmailAddress email);
}