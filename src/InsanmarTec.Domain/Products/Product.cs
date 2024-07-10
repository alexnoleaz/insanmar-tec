using InsanmarTec.Domain.Models;
using InsanmarTec.Domain.Qualities;
using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Products
{
    public class Product : AuditedEntity, IPassivable
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;

        public int QualityId { get; set; }
        public Quality Quality { get; set; } = null!;

        public Product() => IsActive = true;
    }
}
