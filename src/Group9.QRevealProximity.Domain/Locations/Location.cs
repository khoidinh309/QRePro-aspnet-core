using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Group9.QRevealProximity.Locations
{
    public class Location : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        public string Name { get; set; }
        public string  Address { get; set; }
        public string Description { get; set; }
        public string ImageFileName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsDeleted { get; set; }
    }
}
