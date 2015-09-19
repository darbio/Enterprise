using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Repositories;

namespace Data.Repositories
{
    public abstract class MongoRepository<TEntity> : IRepository<TEntity>
    {
        private string _collectionName;

        protected MongoRepository(string collectionName)
        {
            _collectionName = collectionName;
        }

        public TEntity Create(TEntity entity)
        {
            return entity;
            throw new NotImplementedException();
        }

        public TEntity GetById(string id)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
