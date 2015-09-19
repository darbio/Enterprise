using System.Collections.Generic;
using System.Linq;
using Data.Entities;

namespace Data.Repositories
{
    using Core.Entities;
    using Core.Repositories;

    public class PersonRepository : BaseRepository<IPersonEntity, PersonEntity>, IPersonRepository
    {
        public PersonRepository(string connectionString) : base(connectionString, "People") { }

        public IEnumerable<IPersonEntity> GetByLastName(string lastname)
        {
            return Repository.Where(a => a.LastName == lastname);
        }
    }
}
