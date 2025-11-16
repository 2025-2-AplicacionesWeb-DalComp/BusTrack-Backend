using BusTrack.API.Profiles.Domain.Model.Aggregates; // si no funciona usen al inicio using BusTrack_center_API
using BusTrack.API.Profiles.Domain.Model.Query;

namespace BusTrack.API.Profiles.Domain.Services;
/// <summary>
///     Profile Query Service Interface
/// </summary>
public interface IProfileQueryService
{
    /// <summary>
    ///     Handle Get All Profiles Query
    /// </summary>
    /// <param name="query">
    ///     The <see cref="GetAllProfilesQuery"/> query
    /// </param>
    /// <returns>
    ///     A list of <see cref="Profile"/> objects
    /// </returns>
    Task<IEnumerable<Profile>> Handle(GetAllProfilesQuery query);
    
    /// <summary>
    ///     Handle Get Profile By Id Query
    /// </summary>
    /// <param name="query">
    ///     The <see cref="GetProfileByIdQuery"/> query
    /// </param>
    /// <returns>
    ///     A <see cref="Profile"/> object or null if not found
    /// </returns>
    Task<Profile?> Handle(GetProfileByIdQuery query);
    
    /// <summary>
    ///     Handle Get Profile By Email Query
    /// </summary>
    /// <param name="query">
    ///     The <see cref="GetProfileByEmailQuery"/> query
    /// </param>
    /// <returns>
    ///     A <see cref="Profile"/> object or null if not found
    /// </returns>
    Task<Profile?> Handle(GetProfileByEmailQuery query);
}
