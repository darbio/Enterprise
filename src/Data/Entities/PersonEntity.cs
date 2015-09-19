using System;
using MongoRepository;

namespace Data.Entities
{
    using Core.Entities;

    // TODO: Remove the dependency on `MongoRepository.Entity`. This is causing a leakage of Repository up to higher dependencies
    public class PersonEntity : Entity, IPersonEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
