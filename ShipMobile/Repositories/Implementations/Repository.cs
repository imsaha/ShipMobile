using Microsoft.EntityFrameworkCore;
using ShipMobile.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Repositories.Implementations
{
    public class Repository<TEntity> : ReadOnlyRepository<TEntity>, IRepository<TEntity> where TEntity : class
    {
        readonly DbSet<TEntity> set;
        public Repository(DbContext dbContext) : base(dbContext)
        {
            set = dbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            set.Add(entity);
            return entity;
        }


        public TEntity Update(TEntity entity)
        {
            set.Update(entity);
            return entity;
        }

        public void Delete(TEntity entity)
        {
            set.Remove(entity);
        }

        public ICollection<TEntity> AddRange(ICollection<TEntity> entities)
        {
            set.AddRange(entities);
            return entities;
        }

        public ICollection<TEntity> UpdateRange(ICollection<TEntity> entities)
        {
            set.UpdateRange(entities);
            return entities;
        }

        public void DeleteRange(ICollection<TEntity> entities)
        {
            set.RemoveRange(entities);
        }
    }
}
