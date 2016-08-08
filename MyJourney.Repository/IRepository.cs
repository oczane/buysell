using System.Collections.Generic;

namespace MyJourney.AppRepository
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Delete(object id);
        void Update(TEntity entityToUpdate);
    }
}
