using BusTrack.API.Profiles.Domain.Model.ValueObjects; // si no funciona usen al inicio using BusTrack_center_API

namespace BusTrack.API.Profiles.Domain.Model.Query;
/// <summary>
///     Get Profile By Email Query
/// </summary>
/// <param name="Email">
///     The <see cref="EmailAddress"/> email address of the profile to retrieve
/// </param>
public record GetProfileByEmailQuery(EmailAddress Email);
