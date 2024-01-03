using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Group9.QRevealProximity.Locations;

public interface ILocationServices : IApplicationService
{
    public Task<LocationDto> CreateAsync(CreateLocationDto location);
    public Task<LocationDto> GetLocationInfo(SearchLocationDto location);
    public Task<LocationDto> UpdateAsync(UpdateLocationDto location);
    public Task<bool> DeleteAsync(Guid id);
    public Task<List<ScannedLocationDto>> GetScannedLocation();
    public Task<bool> DeleteScanable(Guid id);
}