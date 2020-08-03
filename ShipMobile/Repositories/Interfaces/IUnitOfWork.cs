using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Repositories.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {  
        Task<int> CompleteAsync();
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
