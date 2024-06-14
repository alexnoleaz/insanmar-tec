
namespace InsanmarTec.Domain.Shared.Entities.Auditing
{
    /// <summary>
    /// A shortcut of <see cref="FullAuditedEntity{TPrimaryKey}"/> for most used primary key type (<see cref="int"/>).
    /// </summary>
    public abstract class FullAuditedEntity : FullAuditedEntity<int>, IEntity { }

    /// <summary>
    /// Implements <see cref="IHasDeletionTime"/> to be a base class for full-audited entities.
    /// </summary>
    /// <typeparam name="TPrimaryKey">Type of the primary key of the entity</typeparam>
    public abstract class FullAuditedEntity<TPrimaryKey> : AuditedEntity<TPrimaryKey>, IHasDeletionTime
    {
        /// <summary>
        /// Is this entity Deleted?
        /// </summary>
        public virtual bool IsDeleted { get; set; }

        /// <summary>
        /// Deletion time of this entity.
        /// </summary>
        public virtual DateTime? DeletionTime { get; set; }
    }
}
