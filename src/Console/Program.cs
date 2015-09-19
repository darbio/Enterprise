using System;
using Core.Factories;

namespace Console
{
    using Bootstrapper;

    using Core.Services;

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize
            Bootstrapper.Init();

            // Locate our person service
            var personService = Bootstrapper.Locate<IPersonService>();

            // Locate our person factory
            var personFactory = Bootstrapper.Locate<IPersonFactory>();

            // Create our person
            var person = personFactory.FactoryMethod(p =>
            {
                p.FirstName = "James";
                p.LastName = "Darbyshire";
                p.DateOfBirth = new DateTime(1966, 1, 31);
            });

            // Save our person
            person = personService.Save(person);

            // Retrieve our person
            var peopleCalledDarbyshire = personService.GetByLastName(person.LastName);

            System.Console.ReadKey();
        }
    }
}
