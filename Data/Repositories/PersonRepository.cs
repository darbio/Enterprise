using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    using Core.Entities;
    using Core.Repositories;

    using Data.Entities;

    public class PersonRepository : IPersonRepository
    {
        public IPersonEntity Save(IPersonEntity entity)
        {
            var mapped = Mapper.Map<PersonEntity>(entity);
            return mapped;
        }

        public IEnumerable<IPersonEntity> GetList()
        {
            return new List<PersonEntity>();
        }
    }
}
