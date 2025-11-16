using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Profiles.Domain.Model.Command;
using ACME.LearningCenterPlatform.API.Profiles.Domain.Repositories;
using ACME.LearningCenterPlatform.API.Profiles.Domain.Services;
using ACME.LearningCenterPlatform.API.Shared.Domain.Repositories;
using BCrypt.Net;

namespace ACME.LearningCenterPlatform.API.Profiles.Application.Internal.CommandServices;

public class ProfileCommandService(
    IProfileRepository profileRepository,
    IUnitOfWork unitOfWork) : IProfileCommandService
{
    public async Task<Profile?> Handle(CreateProfileCommand command)
    {
        // Hashear la contraseña antes de crear el perfil
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(command.Password);
        
        var profile = new Profile(command.Username, command.EmailAddress, passwordHash, command.PhotoUrl);
        try
        {
            await profileRepository.AddAsync(profile);
            await unitOfWork.CompleteAsync();
            return profile;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<Profile?> Handle(UpdateProfileCommand command)
    {
        var profile = await profileRepository.FindByIdAsync(command.ProfileId);
        if (profile is null) return null;
        
        profile.Update(command.Username, command.PhotoUrl);
        
        try
        {
            profileRepository.Update(profile);
            await unitOfWork.CompleteAsync();
            return profile;
        }
        catch (Exception e)
        {
            return null;
        }
    }
}