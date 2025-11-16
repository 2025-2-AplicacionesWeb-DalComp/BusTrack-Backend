using BusTrack.API.Profiles.Domain.Model.Command; // si no funciona usen al inicio using BusTrack_center_API
using BusTrack.API.Profiles.Domain.Model.ValueObjects;

namespace BusTrack.API.Profiles.Domain.Model.Aggregates;

public partial class Profile
{
    public int Id { get; set; }
    public string Username { get; private set; }
    public EmailAddress Email { get; private set; }
    public string PasswordHash { get; private set; }
    public string PhotoUrl { get; private set; }
    
    public string EmailAddress => Email.Address;
    
    public Profile()
    {
        Username = string.Empty;
        Email = new EmailAddress();
        PasswordHash = string.Empty;
        PhotoUrl = string.Empty;
    }
    
    public Profile(string username, string emailAddress, string passwordHash, string photoUrl)
    {
        Username = username;
        Email = new EmailAddress(emailAddress);
        PasswordHash = passwordHash;
        PhotoUrl = photoUrl;
    }
    
    /// <summary>
    /// Updates the profile information.
    /// </summary>
    /// <param name="username">The new username</param>
    /// <param name="photoUrl">The new photo URL</param>
    public void Update(string username, string photoUrl)
    {
        Username = username;
        PhotoUrl = photoUrl;
    }
}
