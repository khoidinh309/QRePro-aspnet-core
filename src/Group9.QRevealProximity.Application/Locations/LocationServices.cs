using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group9.QRevealProximity.ScanHistory;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Uow;

namespace Group9.QRevealProximity.Locations;

[RemoteService(false)]

public class LocationServices : QRevealProximityAppService, ILocationServices
{
    public readonly IRepository<Location, Guid> _locationRepository;
    public readonly IRepository<IdentityUser, Guid> _userRepository;
    public readonly IRepository<Scannable, Guid> _scannableRepository;
    
    public LocationServices(IRepository<Location, Guid> locationRepository, 
        IRepository<IdentityUser, Guid> userRepository,
        IRepository<Scannable, Guid> scannableRepository
    )
    {
        this._locationRepository = locationRepository;
        this._userRepository = userRepository;
        this._scannableRepository = scannableRepository;
    }
    
    public async Task<LocationDto> CreateAsync(CreateLocationDto location)
    {
        var newLocation = new Location
        {
            Name = location.Name,
            Address = location.Address,
            Description = location.Description,
            Latitude = 0,
            Longitude = 0,
        };

        await this._locationRepository.InsertAsync(newLocation);

        return ObjectMapper.Map<Location, LocationDto>(newLocation);
    }

    public async Task<LocationDto> GetLocationInfo(SearchLocationDto location)
    {
        var searchLocation = await this._locationRepository
            .SingleOrDefaultAsync(l => l.Name == location.Name);

        if (searchLocation == null)
        {
            throw new UserFriendlyException("Location not found");
        }

        var scannable = new Scannable
        {
            LocationId = searchLocation.Id,
            UserId = (Guid)(CurrentUser?.Id)
        };

        await _scannableRepository.InsertAsync(scannable);
        await CurrentUnitOfWork?.SaveChangesAsync();
        
        return ObjectMapper.Map<Location, LocationDto>(searchLocation);
    }

    public async Task<LocationDto> UpdateAsync(UpdateLocationDto location)
    {
        var oldLocation = await this._locationRepository.GetAsync(location.Id);
        
        oldLocation.Name = location?.Name?? oldLocation.Name;
        oldLocation.Address = location?.Address ?? oldLocation.Address;
        oldLocation.Description = location?.Description ?? oldLocation.Description;
        oldLocation.Longitude = location?.Longitude ?? oldLocation.Longitude;
        oldLocation.Latitude = location?.Latitude ?? oldLocation.Latitude;

        await this._locationRepository.UpdateAsync(oldLocation);

        return ObjectMapper.Map<Location, LocationDto>(oldLocation);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var deleteLocation = await this._locationRepository.GetAsync(id);

        if (deleteLocation == null)
        {
            throw new UserFriendlyException("Location not found");
        }

        await this._locationRepository.DeleteAsync(id);

        return true;
    }

    public async Task<List<ScannedLocationDto>> GetScannedLocation()
    {
        var userId = (Guid)(CurrentUser?.Id);

        if(userId == null)
        {
            throw new UserFriendlyException("Error");
        }

        var scannedLocation = await _scannableRepository.GetListAsync((s) => (s.UserId == userId));

        var scannedLocationDto = new List<ScannedLocationDto>();

        for(var i = 0; i < scannedLocation.Count();i++)
        {
            var locationName = await _locationRepository.GetAsync(scannedLocation[i].LocationId);
            scannedLocationDto.Add(new ScannedLocationDto
            {
                UserId = scannedLocation[i].UserId,
                LocationId = scannedLocation[i].LocationId,
                LocationName = locationName.Name,
                CreationTime = scannedLocation[i].CreationTime,
                Id = scannedLocation[i].Id,
            });
        }

        return scannedLocationDto;
    }

    private async Task<string> GetNameOfLocation(Guid id)
    {
        var location = await _locationRepository.GetAsync(id);
        return location.Name;
    }

    public async Task<bool> DeleteScanable(Guid id)
    {
        if(id == Guid.Empty)
        {
            return false;
        }

        await _scannableRepository.DeleteAsync(id);

        return true;
    }
}