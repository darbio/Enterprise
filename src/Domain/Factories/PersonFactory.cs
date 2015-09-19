using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Factories;
using Core.Models;
using Domain.Models;

namespace Domain.Factories
{
    public class PersonFactory : IPersonFactory
    {
        public IPerson FactoryMethod()
        {
            // Return
            return new Person();
        }

        public IPerson FactoryMethod(Action<IPerson> initializer)
        {
            // Create a new Person
            var person = new Person();

            // Apply our initializer properties
            initializer(person);

            // Return
            return person;
        }
    }
}
