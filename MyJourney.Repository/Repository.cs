using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using MyJourney.Models;

namespace MyJourney.AppRepository
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        internal BuySellContext context = new BuySellContext();
        internal DbSet<TEntity> dbSet;

        public Repository()
        {
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get()
        {
            IQueryable<TEntity> query = dbSet;
            return query.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public virtual TEntity InsertReturnEntity(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
