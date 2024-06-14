using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Domain.Shared.Datasources
{
    /// <summary>
    /// This interface must be implemented by all datasources to identify them by convention.
    /// Implement generic version instead of this one.
    /// </summary>
    public interface IDatasource : ITransientDependency { }
}
