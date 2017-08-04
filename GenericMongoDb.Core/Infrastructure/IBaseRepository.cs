using GenericMongoDb.Core.Domain;
using System.Collections.Generic;

namespace GenericMongoDb.Core.Infrastructure
{
    public interface IBaseRepository<T> where T : Entity
    {
        T GetByID(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
