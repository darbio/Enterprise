using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    using Core.Models;

    public interface IPersonService : IService
    {
        IPerson Save(IPerson person);

        IEnumerable<IPerson> GetList();

        IEnumerable<IPerson> GetByLastName(string lastname);
    }
}
