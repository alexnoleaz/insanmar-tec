namespace InsanmarTec.Domain.Shared.Entities.Auditing
{
    /// <summary>
    /// A shortcut of <see cref="CreationAuditedEntity{TPrimaryKey}"/> for most used primary key type (<see cref="int"/>).
    /// </summary>
    public abstract class CreationAuditedEntity : CreationAuditedEntity<int>, IEntity { }

    /// <summary>
    /// This class can be used to simplify implementing <see cref="IHasCreationTime"/>.
    /// </summary>
    /// <typeparam name="TPrimaryKey">Type of the primary key of the entity</typeparam>
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, IHasCreationTime
    {
        /// <summary>
        /// Creation time of this entity.
        /// </summary>
        public virtual DateTime CreationTime { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        protected CreationAuditedEntity()
        {
            CreationTime = DateTime.Now;
        }
    }
}
