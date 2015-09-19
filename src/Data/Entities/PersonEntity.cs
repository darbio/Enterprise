using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoRepository;

namespace Data.Entities
{
    using Core.Entities;

    // TODO: Remove the dependency on Entity. This is causing a leakage of MongoRepository up to higher dependencies
    public class PersonEntity : Entity, IPersonEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
