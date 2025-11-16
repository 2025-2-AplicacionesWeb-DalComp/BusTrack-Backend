using BusTrack.API.Profiles.Domain.Model.Aggregates; // si no funciona usen al inicio using BusTrack_center_API
using BusTrack.API.Profiles.Domain.Model.Command;
using BusTrack.API.Profiles.Domain.Repositories;
using BusTrack.API.Profiles.Domain.Services;
using BusTrack.API.Shared.Domain.Repositories;
using BCrypt.Net;

namespace BusTrack.API.Profiles.Application.Internal.CommandServices;

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
