namespace ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Command;

public record CreateProfileCommand(
    string Username,
    string EmailAddress,
    string Password,
    string PhotoUrl);