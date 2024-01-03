using Volo.Abp.Application.Dtos;
using System;
namespace Group9.QRevealProximity.Locations;

public class UpdateLocationDto : AuditedEntityDto<Guid>
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Description { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}