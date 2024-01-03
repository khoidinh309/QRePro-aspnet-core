using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Group9.QRevealProximity.Locations
{
    public class ScannedLocationDto : AuditedEntityDto<Guid>
    {
        public Guid LocationId { get; set; }
        public Guid UserId { get; set; }
        public string LocationName { get; set; }
    }
}
