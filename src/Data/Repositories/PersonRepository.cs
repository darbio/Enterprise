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

    public class PersonRepository : BaseRepository<IPersonEntity, PersonEntity>, IPersonRepository
    {
        public IEnumerable<IPersonEntity> GetByLastName(string lastname)
        {
            return MongoRepository.Where(a => a.LastName == lastname);
        }
    }
}
