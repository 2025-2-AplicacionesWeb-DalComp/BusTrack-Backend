namespace BusTrack.API.Profiles.Domain.Model.Command; // si no funciona usen al inicio using BusTrack_center_API

public record CreateProfileCommand(
    string Username,
    string EmailAddress,
    string Password,
    string PhotoUrl);
