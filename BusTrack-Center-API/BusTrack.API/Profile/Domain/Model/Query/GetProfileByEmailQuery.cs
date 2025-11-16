using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Query;
/// <summary>
///     Get Profile By Email Query
/// </summary>
/// <param name="Email">
///     The <see cref="EmailAddress"/> email address of the profile to retrieve
/// </param>
public record GetProfileByEmailQuery(EmailAddress Email);