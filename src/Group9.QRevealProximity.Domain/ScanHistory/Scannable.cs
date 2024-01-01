using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Group9.QRevealProximity.ScanHistory
{
    public class Scannable : AuditedEntity<Guid>, ISoftDelete
    {
        public Guid UserId { get; set; }
        public Guid LocationId { get; set; }

        public bool IsDeleted { set; get; }
    }
}
