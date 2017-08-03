using GenericMongoDb.Core.Domain;
using System.Collections.Generic;

namespace GenericMongoDb.Core.Repository
{
    public interface IBaseRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        void Add(T entity);

        void Delete(T entity);
    }
}
