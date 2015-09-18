using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private static IContainer Container;

        public static void Init()
        {
            InitializeDependencies();
        }

        /// <summary>
        /// Resolves the type from the type parameter repository input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>An instance of type T</returns>
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
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

            // Repositories
            builder.RegisterType<PersonRepository>().As<IPersonRepository>();

            // Services
            builder.RegisterType<PersonService>().As<IPersonService>();

            Container = builder.Build();
        }
    }
}
