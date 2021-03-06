﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    using Core.Entities;
    using Core.Models;
    using Core.Repositories;
    using Core.Services;

    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IPerson Save(IPerson person)
        {
            // Map IPerson to IPersonEntity
            // Send to our repository
            var entity = _personRepository.Create(Mapper.Map<IPersonEntity>(person));

            // Map IPersonEntity to IPerson
            person = Mapper.Map<Person>(entity);

            // Return
            return person;
        }

        public IEnumerable<IPerson> GetList()
        {
            // Get our Persons from the repository
            var entities = _personRepository.GetList();

            // Map IPersonEntity to IPerson
            var persons = Mapper.Map<IEnumerable<Person>>(entities);

            // Return
            return persons;
        }

        public IEnumerable<IPerson> GetByLastName(string lastname)
        {
            // Get our persons from the repository
            var entities = _personRepository.GetByLastName(lastname);

            // Map IPersonEntity to IPerson
            var persons = Mapper.Map<IEnumerable<Person>>(entities);

            // Return
            return persons;
        }
    }
}
