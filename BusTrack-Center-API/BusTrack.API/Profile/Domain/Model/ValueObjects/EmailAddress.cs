namespace BusTrack.API.Profiles.Domain.Model.ValueObjects; // si no funciona usen al inicio using BusTrack_center_API
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
