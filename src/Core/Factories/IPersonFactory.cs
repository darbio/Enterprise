using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Factories
{
    public interface IPersonFactory
    {
        IPerson FactoryMethod();

        IPerson FactoryMethod(Action<IPerson> initializer);
    }
}
