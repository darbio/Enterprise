using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    using Bootstrapper;

    using Core.Services;

    using Domain.Models;

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize
            Bootstrapper.Init();

            // Resolve our Person Service
            var personService = Bootstrapper.Resolve<IPersonService>();
            
            // Create our person
            var person = new Person()
            {
                FirstName = "James",
                LastName = "Darbyshire",
                DateOfBirth = new DateTime(1966, 1, 31)
            };

            // Save our person
            personService.Save(person);
        }
    }
}
