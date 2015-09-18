using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    using Core.Entities;
    using Core.Models;
    using Core.Repositories;
    using Core.Services;

    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public void Save(IPerson person)
        {
            // Map IPerson to IPersonEntity
            // Send to our repository
            var entity = personRepository.Save(Mapper.Map<IPersonEntity>(person));
        }

        public IEnumerable<IPerson> GetList()
        {
            // Get our Persons from the repository

            // Map IPersonEntity to IPerson

            // Return
            return new List<IPerson>();
        }
    }
}
