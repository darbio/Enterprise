﻿using System;
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
    using Domain.Services;

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
        /// <typeparam name="T">An ILocatable type</typeparam>
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
            var connectionString = "mongodb://localhost/test"; // TODO move this elsehere
            builder.RegisterInstance(new PersonRepository(connectionString)).As<IPersonRepository>();

            // Services
            builder.RegisterType<PersonService>().As<IPersonService>();

            _container = builder.Build();
        }
    }
}
