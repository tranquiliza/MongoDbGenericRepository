using GenericMongoDb.Core.Domain;
using System;
using System.Collections.Generic;

namespace GenericMongoDb.Core.Infrastructure
{
    public interface IBaseRepository<T> where T : Entity
    {
        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        void DeleteAll();
    }
}
