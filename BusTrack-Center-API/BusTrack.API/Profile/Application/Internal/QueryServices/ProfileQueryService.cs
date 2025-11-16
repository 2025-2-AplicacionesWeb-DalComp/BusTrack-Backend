using BusTrack.API.Profiles.Domain.Model.Aggregates;// si no funciona usen al inicio using BusTrack_center_API
using BusTrack.API.Profiles.Domain.Model.Query;
using BusTrack.API.Profiles.Domain.Repositories;
using BusTrack.API.Profiles.Domain.Services;

namespace ACME.LearningCenterPlatform.API.Profiles.Application.Internal.QueryServices;

public class ProfileQueryService(IProfileRepository profileRepository) : IProfileQueryService
{
    public async Task<IEnumerable<Profile>> Handle(GetAllProfilesQuery query)
    {
        return await profileRepository.ListAsync();
    }

    public async Task<Profile?> Handle(GetProfileByIdQuery query)
    {
        return await profileRepository.FindByIdAsync(query.ProfileId);
    }

    public async Task<Profile?> Handle(GetProfileByEmailQuery query)
    {
        return await profileRepository.FindProfileByEmailAsync(query.Email);
    }
}
