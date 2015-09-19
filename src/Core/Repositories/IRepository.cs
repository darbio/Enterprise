using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRepository<TEntity>
    {
        TEntity Create(TEntity entity);

        TEntity GetById(string id);

        TEntity Update(TEntity entity);

        void Delete(string id);

        IQueryable<TEntity> GetList();
    }
}
