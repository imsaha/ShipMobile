using Microsoft.EntityFrameworkCore;
using ShipMobile.Data;
using ShipMobile.Data.Models;
using ShipMobile.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Repositories.Implementations
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DbContext dbContext;
        private bool disposed;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IRepository<TEntity> GetRepository<TEntity>() where TEntity:class
        {
            return new Repository<TEntity>(dbContext);
        }


        public Task<int> CompleteAsync() => dbContext.SaveChangesAsync();

        #region IDisposable

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
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
