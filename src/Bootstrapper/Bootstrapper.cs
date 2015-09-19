using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Factories;
using Domain.Factories;

namespace Bootstrapper
{
    using Autofac;

    using Core.Entities;
    using Core.Models;
    using Core.Repositories;
    using Core.Services;

    using Data.Entities;
    using Data.Repositories;

    using Domain.Models;

    using Services.Services;

    public static class Bootstrapper
    {
        private static IContainer _container;

        public static void Init()
        {
            InitializeDependencies();
        }

        /// <summary>
        /// Locates the type from the type parameter input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>An instance of type T</returns>
        public static T Locate<T>() where T : ILocatable
        {
            using (_container.BeginLifetimeScope())
            {
                return _container.Resolve<T>();
            }
        }

        /// <summary>
        /// Sets up our IoC container
        /// </summary>
        static void InitializeDependencies()
        {
            var builder = new ContainerBuilder();

            // Entities
            builder.RegisterType<PersonEntity>().As<IPersonEntity>();

            // Models
            builder.RegisterType<Person>().As<IPerson>();
            
            // Factories
            // Register as instances so that each one is re-used
            builder.RegisterInstance(new PersonFactory()).As<IPersonFactory>();

            // Repositories
            // Register as instances so that each one is re-used
            builder.RegisterInstance(new PersonRepository()).As<IPersonRepository>();

            // Services
            builder.RegisterType<PersonService>().As<IPersonService>();

            _container = builder.Build();
        }
    }
}
