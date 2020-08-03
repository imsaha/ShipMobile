using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMobile.Repositories.Interfaces
{
    public interface IRepository<TEntity> :IReadOnlyRepository<TEntity> where TEntity:class
    {
        TEntity Add(TEntity entity);
        ICollection<TEntity> AddRange(ICollection<TEntity> entities);

        void Delete(TEntity entity);
        void DeleteRange(ICollection<TEntity> entities);

        TEntity Update(TEntity entity);
        ICollection<TEntity> UpdateRange(ICollection<TEntity> entities);
    }
}
