namespace Core.Repositories
{
    using System.Collections.Generic;

    using Core.Entities;

    public interface IPersonRepository
    {
        IPersonEntity Save(IPersonEntity entity);

        IEnumerable<IPersonEntity> GetList();
    }
}
