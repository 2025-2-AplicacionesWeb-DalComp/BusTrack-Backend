using BusTrack.API.Profiles.Domain.Model.Aggregates; // si no funciona usen al inicio using BusTrack_center_API
using BusTrack.API.Profiles.Domain.Model.ValueObjects;
using BusTrack.API.Shared.Domain.Repositories;

namespace BusTrack.API.Profiles.Domain.Repositories;
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
