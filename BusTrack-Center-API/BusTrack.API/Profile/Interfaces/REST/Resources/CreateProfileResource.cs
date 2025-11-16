namespace ACME.LearningCenterPlatform.API.Profiles.Interfaces.REST.Resources;

public record CreateProfileResource(
    string Username,
    string Email,
    string Password,
    string PhotoUrl
);