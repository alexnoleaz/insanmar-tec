namespace InsanmarTec.Domain.Shared.Entities.Auditing
{
    public class EntityAuditingHelper
    {
        public static void SetCreationAuditProperties(object entityAsObj)
        {
            if (entityAsObj is not IHasCreationTime entityWithCreationTime) //Object does not implement IHasCreationTime
                return;

            if (entityWithCreationTime.CreationTime == default)
                entityWithCreationTime.CreationTime = DateTime.Now;
        }

        public static void SetModificationAuditProperties(object entityAsObj, bool isSavingEnabled)
        {
            if (entityAsObj is not IHasModificationTime entityWithModificationTime) // Object does not implement IHasModificationTime
                return;

            if (entityWithModificationTime.LastModificationTime is null || isSavingEnabled)
                entityWithModificationTime.LastModificationTime = DateTime.Now;
        }

        public static void SetDeletionAuditProperties(object entityAsObj, bool isSavingEnabled)
        {

            if (entityAsObj is not IHasDeletionTime entityWithDeletionTime) // Object does not implement IHasDeletionTime
                return;

            if (entityWithDeletionTime.DeletionTime is null || isSavingEnabled)
                entityWithDeletionTime.DeletionTime = DateTime.Now;
        }
    }
}
