using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using MongoDB.Driver;
using MongoRepository;

namespace Data.Repositories
{
    using Core.Entities;
    using Core.Repositories;

    public class PersonRepository : IPersonRepository
    {
        private MongoRepository<PersonEntity> _mongoRepository = new MongoRepository<PersonEntity>("mongodb://localhost/test", "Persons");

        public IPersonEntity Create(IPersonEntity entity)
        {
            return _mongoRepository.Add(Mapper.Map<PersonEntity>(entity));
        }

        public IPersonEntity GetById(string id)
        {
            return _mongoRepository.GetById(id);
        }

        public IPersonEntity Update(IPersonEntity entity)
        {
            return _mongoRepository.Update(Mapper.Map<PersonEntity>(entity));
        }

        public void Delete(string id)
        {
            _mongoRepository.Delete(id);
        }

        public IQueryable<IPersonEntity> GetList()
        {
            return _mongoRepository.AsQueryable();
        }

        public IEnumerable<IPersonEntity> GetByLastName(string lastname)
        {
            return _mongoRepository.Where(a => a.LastName == lastname);
        }
    }
}
