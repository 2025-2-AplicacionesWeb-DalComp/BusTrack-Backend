namespace ACME.LearningCenterPlatform.API.Profiles.Domain.Model.ValueObjects;
/// <summary>
///     Email Address Value Object
/// </summary>
/// <param name="Address">
///     The email address string
/// </param>
public record EmailAddress(string Address)
{
    public EmailAddress(): this(string.Empty) { }
}