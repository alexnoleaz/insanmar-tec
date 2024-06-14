namespace InsanmarTec.Domain.Shared.Entities.Auditing
{
    /// <summary>
    /// A shortcut of <see cref="AuditedEntity{TPrimaryKey}"/> for most used primary key type (<see cref="int"/>).
    /// </summary>
    public abstract class AuditedEntity : AuditedEntity<int>, IEntity { }

    /// <summary>
    /// This class can be used to simplify implementing <see cref="IHasModificationTime"/>.
    /// </summary>
    /// <typeparam name="TPrimaryKey">Type of the primary key of the entity</typeparam>
    public abstract class AuditedEntity<TPrimaryKey> : CreationAuditedEntity<TPrimaryKey>, IHasModificationTime
    {
        /// <summary>
        /// Last modification date of this entity.
        /// </summary>
        public virtual DateTime? LastModificationTime { get; set; }
    }
}
