namespace EventsApi.Data.Repository
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Interfaces;

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly Context context;
        private DbSet<TEntity> dbSet;

        public GenericRepository(Context context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public bool DEleteById(object id)
        {
            TEntity entityToRemove = GetById(id);
            if (entityToRemove != null)
            {
                Delete(entityToRemove);
                return true;
            }
            return false;
        }

        public IEnumerable<TEntity> Get()
        {
            return dbSet.ToList();
        }

        public TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
