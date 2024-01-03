using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Group9.QRevealProximity.Locations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Group9.QRevealProximity.Controllers.Locations;

[ApiController]
[Route("api/[controller]/[action]")]
public class LocationController : QRevealProximityController
{
    private readonly ILocationServices _locationSearvice;

    public LocationController(ILocationServices locationSearvice)
    {
        this._locationSearvice = locationSearvice;
    }

    [HttpGet]
    public async Task<List<ScannedLocationDto>> GetScannedLocation()
    {
        return await _locationSearvice.GetScannedLocation();
    }

    [HttpPost]
    public async Task<LocationDto> CreateAsync(CreateLocationDto location)
    {
        return await this._locationSearvice.CreateAsync(location);
    }

    [HttpPost]
    public async Task<LocationDto> GetLocationInfo(SearchLocationDto location)
    {
        return await this._locationSearvice.GetLocationInfo(location);
    }

    [HttpPost]
    public async Task<LocationDto> UpdateAsync(UpdateLocationDto location)
    {
        return await this._locationSearvice.UpdateAsync(location);
    }

    [HttpDelete]
    public async Task<bool> DeleteAsync(Guid id)
    {
        return await this._locationSearvice.DeleteAsync(id);
    }

    [HttpDelete]
    public async Task<bool> DeleteScanable(Guid id)
    {
        return await this._locationSearvice.DeleteScanable(id);
    }
}