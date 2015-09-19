using System.Linq;
using MongoRepository;

namespace Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInterfaceEntity">The interface which we are to return</typeparam>
    /// <typeparam name="TEntityImplementation">The concrete implementation of the interface to persist</typeparam>
    public abstract class BaseRepository<TInterfaceEntity, TEntityImplementation> : Core.Repositories.IRepository<TInterfaceEntity>
        where TInterfaceEntity : Core.Entities.IEntity
        where TEntityImplementation : Entity
    {
        internal MongoRepository<TEntityImplementation> Repository;

        protected BaseRepository(string connectionString, string collectionName)
        {
            Repository = new MongoRepository<TEntityImplementation>(connectionString, collectionName);
        } 

        public TInterfaceEntity Create(TInterfaceEntity entity)
        {
            return Mapper.Map<TInterfaceEntity>(Repository.Add(Mapper.Map<TEntityImplementation>(entity)));
        }

        public TInterfaceEntity GetById(string id)
        {
            return Mapper.Map<TInterfaceEntity>(Repository.GetById(id));
        }

        public TInterfaceEntity Update(TInterfaceEntity entity)
        {
            return Mapper.Map<TInterfaceEntity>(Repository.Update(Mapper.Map<TEntityImplementation>(entity)));
        }

        public void Delete(string id)
        {
            Repository.Delete(id);
        }

        public IQueryable<TInterfaceEntity> GetList()
        {
            return Mapper.Map<IQueryable<TInterfaceEntity>>(Repository.AsQueryable());
        }
    }
}
