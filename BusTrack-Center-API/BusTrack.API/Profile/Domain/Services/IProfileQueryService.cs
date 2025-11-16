using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Query;

namespace ACME.LearningCenterPlatform.API.Profiles.Domain.Services;
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