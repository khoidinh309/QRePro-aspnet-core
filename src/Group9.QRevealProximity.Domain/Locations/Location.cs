using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Group9.QRevealProximity.Locations
{
    public class Location : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string  Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
