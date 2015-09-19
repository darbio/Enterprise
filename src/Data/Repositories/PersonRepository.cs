using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    using Core.Entities;
    using Core.Repositories;

    public class PersonRepository : MongoRepository<IPersonEntity>, IPersonRepository
    {
        public PersonRepository() : base("Persons") { }
    }
}
