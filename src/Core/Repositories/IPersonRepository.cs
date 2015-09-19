namespace Core.Repositories
{
    using System.Collections.Generic;

    using Entities;

    public interface IPersonRepository : IRepository<IPersonEntity>
    {
        IEnumerable<IPersonEntity> GetByLastName(string lastname);
    }
}
