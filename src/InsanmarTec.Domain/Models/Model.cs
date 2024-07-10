using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Models
{
    public class Model : AuditedEntity, IPassivable
    {
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        public Model() => IsActive = true;
    }
}
