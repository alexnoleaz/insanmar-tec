using System.Linq.Expressions;
using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.IdentityModel.Tokens;

namespace InsanmarTec.Infrastructure.Shared.Persistence.Datasources
{
    /// <summary>
    /// Implements IDatasource for Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity">Type of the Entity for this datasource</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key of the entity</typeparam>
    public class Datasource<TEntity, TPrimaryKey> : IDatasource<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly InsanmarTecDbContext _context;

        public Datasource(InsanmarTecDbContext context) => _context = context;

        #region Select/Get/Query

        public IQueryable<TEntity> GetAll() => Table.AsQueryable();

        public IQueryable<TEntity> GetAllReadonly() => GetAll().AsNoTracking();

        public Task<IQueryable<TEntity>> GetAllReadonlyAsync() =>
            Task.FromResult(Table.AsNoTracking().AsQueryable());

        public Task<IQueryable<TEntity>> GetAllAsync() => Task.FromResult(Table.AsQueryable());

        public IQueryable<TEntity> GetAllIncluding(
            params Expression<Func<TEntity, object>>[] propertySelectors
        )
        {
            if (propertySelectors.IsNullOrEmpty())
                return GetAll();

            var query = GetAll();
            foreach (var propertySelector in propertySelectors)
                query = query.Include(propertySelector);

            return query;
        }

        public async Task<IQueryable<TEntity>> GetAllIncludingAsync(
            params Expression<Func<TEntity, object>>[] propertySelectors
        )
        {
            if (propertySelectors.IsNullOrEmpty())
                return await GetAllAsync();

            var query = await GetAllAsync();
            foreach (var propertySelector in propertySelectors)
                query = query.Include(propertySelector);

            return query;
        }

        public IQueryable<TEntity> GetAllReadonlyIncluding(
            params Expression<Func<TEntity, object>>[] propertySelectors
        )
        {
            if (propertySelectors.IsNullOrEmpty())
                return GetAllReadonly();

            var query = GetAllReadonly();

            foreach (var propertySelector in propertySelectors)
                query = query.Include(propertySelector);

            return query;
        }

        public async Task<IQueryable<TEntity>> GetAllReadonlyIncludingAsync(
            params Expression<Func<TEntity, object>>[] propertySelectors
        )
        {
            if (propertySelectors.IsNullOrEmpty())
                return await GetAllReadonlyAsync();

            var query = await GetAllReadonlyAsync();

            foreach (var propertySelector in propertySelectors)
                query = query.Include(propertySelector);

            return query;
        }

        public List<TEntity> GetAllList() => GetAll().ToList();

        public async Task<List<TEntity>> GetAllListAsync() =>
            await Table.AsQueryable().ToListAsync();

        public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate) =>
            GetAll().Where(predicate).ToList();

        public async Task<List<TEntity>> GetAllListAsync(
            Expression<Func<TEntity, bool>> predicate
        ) => await Table.AsQueryable().Where(predicate).ToListAsync();

        public T Query<T>(Func<IQueryable<TEntity>, T> queryMethod) => queryMethod(GetAll());

        public TEntity Get(TPrimaryKey id) =>
            FirstOrDefault(id) ?? throw new EntityNotFoundException(typeof(TEntity), id!);

        public async Task<TEntity> GetAsync(TPrimaryKey id) =>
            (await FirstOrDefaultAsync(id))
            ?? throw new EntityNotFoundException(typeof(TEntity), id!);

        public TEntity Single(Expression<Func<TEntity, bool>> predicate) =>
            GetAll().Single(predicate);

        public async Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate) =>
            await Table.AsQueryable().SingleAsync(predicate);

        public TEntity FirstOrDefault(TPrimaryKey id) =>
            GetAll().FirstOrDefault(CreateEqualityExpressionForId(id));

        public async Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id) =>
            await Table.AsQueryable().FirstOrDefaultAsync(CreateEqualityExpressionForId(id));

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate) =>
            GetAll().FirstOrDefault(predicate);

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate) =>
            await Table.AsQueryable().FirstOrDefaultAsync(predicate);

        public TEntity Load(TPrimaryKey id) => Get(id);

        #endregion

        #region Insert

        public TEntity Insert(TEntity entity)
        {
            SetCreationAuditProperties(entity);
            try
            {
                var entitySaved = Table.Add(entity).Entity;
                _context.SaveChanges();
                return entitySaved;
            }
            catch (DbUpdateException)
            {
                foreach (
                    var entry in _context
                        .ChangeTracker.Entries()
                        .Where(e => e.State == EntityState.Added)
                )
                    entry.State = EntityState.Detached;
                throw;
            }
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            SetCreationAuditProperties(entity);
            try
            {
                var entitySaved = Table.Add(entity).Entity;
                await _context.SaveChangesAsync();
                return entitySaved;
            }
            catch (DbUpdateException ex)
            {
                foreach (
                    var entry in _context
                        .ChangeTracker.Entries()
                        .Where(e => e.State == EntityState.Added)
                )
                    entry.State = EntityState.Detached;
                throw;
            }
        }

        public TPrimaryKey InsertAndGetId(TEntity entity) => Insert(entity).Id;

        public async Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity) =>
            (await InsertAsync(entity)).Id;

        public TEntity InsertOrUpdate(TEntity entity) =>
            entity.IsTransient() ? Insert(entity) : Update(entity);

        public async Task<TEntity> InsertOrUpdateAsync(TEntity entity) =>
            entity.IsTransient() ? await InsertAsync(entity) : await UpdateAsync(entity);

        public TPrimaryKey InsertOrUpdateAndGetId(TEntity entity) => InsertOrUpdate(entity).Id;

        public async Task<TPrimaryKey> InsertOrUpdateAndGetIdAsync(TEntity entity) =>
            (await InsertOrUpdateAsync(entity)).Id;

        #endregion

        #region Update

        public TEntity Update(TEntity entity)
        {
            AttachIfNot(entity);
            SetModificationAuditProperties(entity);
            Table.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public Task<TEntity> UpdateAsync(TEntity entity) => Task.FromResult(Update(entity));

        public TEntity Update(TPrimaryKey id, Action<TEntity> updateAction)
        {
            var entity = Get(id);
            SetModificationAuditProperties(entity);
            updateAction(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TPrimaryKey id, Func<TEntity, Task> updateAction)
        {
            var entity = await GetAsync(id);
            SetModificationAuditProperties(entity);
            await updateAction(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        #endregion

        #region Delete

        public void Delete(TEntity entity)
        {
            AttachIfNot(entity);

            if (entity is not ISoftDelete || entity is not IHasDeletionTime)
            {
                Table.Remove(entity);
                _context.SaveChanges();
                return;
            }

            DeletionForSoftDelete(entity);
            SetDeletionAuditProperties(entity);
            Table.Update(entity);
            _context.SaveChanges();
        }

        public Task DeleteAsync(TEntity entity)
        {
            Delete(entity);
            return Task.CompletedTask;
        }

        public void Delete(TPrimaryKey id)
        {
            var entity = Table.Local.FirstOrDefault(ent =>
                EqualityComparer<TPrimaryKey>.Default.Equals(ent.Id, id)
            );
            if (entity is null)
            {
                entity = FirstOrDefault(id);
                if (entity is null)
                    return;
            }

            Delete(entity);
        }

        public async Task DeleteAsync(TPrimaryKey id)
        {
            var entity = Table.Local.FirstOrDefault(ent =>
                EqualityComparer<TPrimaryKey>.Default.Equals(ent.Id, id)
            );
            if (entity is null)
            {
                entity = await FirstOrDefaultAsync(id);
                if (entity is null)
                    return;
            }

            await DeleteAsync(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            foreach (var entity in GetAllList(predicate))
                Delete(entity);
        }

        public async Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entities = await GetAllListAsync(predicate);
            foreach (var entity in entities)
                await DeleteAsync(entity);
        }

        #endregion

        #region Aggregates

        public int Count() => GetAllReadonly().Count();

        public async Task<int> CountAsync() =>
            await Table.AsNoTracking().AsQueryable().CountAsync();

        public int Count(Expression<Func<TEntity, bool>> predicate) =>
            GetAllReadonly().Count(predicate);

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate) =>
            await Table.AsNoTracking().AsQueryable().CountAsync(predicate);

        public long LongCount() => GetAllReadonly().LongCount();

        public async Task<long> LongCountAsync() =>
            await Table.AsNoTracking().AsQueryable().LongCountAsync();

        public long LongCount(Expression<Func<TEntity, bool>> predicate) =>
            GetAllReadonly().LongCount(predicate);

        public async Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate) =>
            await Table.AsNoTracking().AsQueryable().LongCountAsync(predicate);

        #endregion

        private void SetCreationAuditProperties(object entityAsObj)
        {
            EntityAuditingHelper.SetCreationAuditProperties(entityAsObj);
        }

        private void SetModificationAuditProperties(object entityAsObj)
        {
            EntityAuditingHelper.SetModificationAuditProperties(entityAsObj, true);
        }

        private void SetDeletionAuditProperties(object entityAsObj)
        {
            EntityAuditingHelper.SetDeletionAuditProperties(entityAsObj, true);
        }

        private void DeletionForSoftDelete(object entityAsObj)
        {
            if (entityAsObj is not ISoftDelete entityWithSoftDelete)
                return;

            var softDeleteEntry = _context.Entry<ISoftDelete>(entityWithSoftDelete);
            softDeleteEntry.Reload();
            softDeleteEntry.State = EntityState.Modified;
            softDeleteEntry.Entity.IsDeleted = true;
        }

        private void AttachIfNot(TEntity entity)
        {
            if (!Table.Local.Contains(entity))
                Table.Attach(entity);
        }

        private Expression<Func<TEntity, bool>> CreateEqualityExpressionForId(TPrimaryKey id)
        {
            var lambdaParam = Expression.Parameter(typeof(TEntity));
            var leftExpression = Expression.PropertyOrField(lambdaParam, "Id");
            var idValue = Convert.ChangeType(id, typeof(TPrimaryKey));

            Expression<Func<object>> closure = () => idValue;
            var rightExpression = Expression.Convert(closure.Body, leftExpression.Type);
            var lambdaBody = Expression.Equal(leftExpression, rightExpression);

            return Expression.Lambda<Func<TEntity, bool>>(lambdaBody, lambdaParam);
        }

        public virtual DbSet<TEntity> Table => _context.Set<TEntity>();
        public virtual DatabaseFacade Database => _context.Database;
    }
}
