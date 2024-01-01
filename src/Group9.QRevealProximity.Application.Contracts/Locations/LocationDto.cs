using System;
using Volo.Abp.Application.Dtos;

namespace Group9.QRevealProximity.Locations
{
    public class LocationDto : AuditedEntityDto<Guid>
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string ImageFileName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
