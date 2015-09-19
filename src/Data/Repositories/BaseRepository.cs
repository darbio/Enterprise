using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories;
using MongoRepository;

namespace Data.Repositories
{
    public class BaseRepository<TInterface, TEntity> : Core.Repositories.IRepository<TInterface>
        where TInterface : Core.Entities.IEntity
        where TEntity : Entity
    {
        internal MongoRepository<TEntity> MongoRepository = new MongoRepository<TEntity>("mongodb://localhost/test", "Persons");

        public TInterface Create(TInterface entity)
        {
            return Mapper.Map<TInterface>(MongoRepository.Add(Mapper.Map<TEntity>(entity)));
        }

        public TInterface GetById(string id)
        {
            return Mapper.Map<TInterface>(MongoRepository.GetById(id));
        }

        public TInterface Update(TInterface entity)
        {
            return Mapper.Map<TInterface>(MongoRepository.Update(Mapper.Map<TEntity>(entity)));
        }

        public void Delete(string id)
        {
            MongoRepository.Delete(id);
        }

        public IQueryable<TInterface> GetList()
        {
            return Mapper.Map<IQueryable<TInterface>>(MongoRepository.AsQueryable());
        }
    }
}
