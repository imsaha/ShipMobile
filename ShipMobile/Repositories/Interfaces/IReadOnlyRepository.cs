using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Repositories.Interfaces
{
    public interface IReadOnlyRepository<TEntity> :IDisposable where TEntity:class
    {
        public IQueryable<TEntity> OpenQuery();
    }
}
