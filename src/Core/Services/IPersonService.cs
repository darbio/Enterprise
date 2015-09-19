using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    using Core.Models;

    public interface IPersonService
    {
        IPerson Save(IPerson person);

        IEnumerable<IPerson> GetList();
    }
}
