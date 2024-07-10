using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Domain.Qualities
{
    public class Quality : Entity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
