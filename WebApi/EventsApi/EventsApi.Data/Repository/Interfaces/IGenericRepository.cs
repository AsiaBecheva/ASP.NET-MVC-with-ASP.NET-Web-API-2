namespace EventsApi.Data.Repository.Interfaces
{
    using System.Collections.Generic;

    public interface IGenericRepository<TEntity>
    {
        TEntity GetById(object id);

        IEnumerable<TEntity> Get();

        void Insert(TEntity entity);

        void Delete(TEntity entity);

        bool DEleteById(object id);

        void Update(TEntity entity);
    }
}
