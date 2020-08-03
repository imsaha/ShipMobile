using Microsoft.EntityFrameworkCore;
using ShipMobile.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Repositories.Implementations
{
    public class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        internal protected readonly DbContext Context;
        bool disposed;
        IQueryable<TEntity> query;

        public ReadOnlyRepository(DbContext dbContext)
        {
            this.Context = dbContext;
            query = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> OpenQuery() => query = query.AsNoTracking();

        #region Helpers

        // FROM VISO Project
        private static Expression<Func<TEntity, bool>> BuildLambdaForFindByKey<TKeyType>(TKeyType id, string keyPropertyName = "Id")
        {
            var item = Expression.Parameter(typeof(TEntity), "entity");
            var prop = Expression.Property(item, keyPropertyName); // Assumes that Key property is always named "Id"
            var value = Expression.Constant(id);
            var equal = Expression.Equal(prop, value);
            var lambda = Expression.Lambda<Func<TEntity, bool>>(equal, item);

            return lambda;
        }


        #endregion

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
