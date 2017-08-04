using GenericMongoDb.Core.Domain;
using GenericMongoDb.Core.Infrastructure;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericMongoDb.Data.Repository
{
    /// <summary>
    /// Base repository for CRUD operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected IMongoDatabase _Context;
        protected IMongoCollection<T> _Collection;

        /// <summary>
        /// Do we want to pass a client, or just the database?
        /// </summary>
        /// <param name="database"></param>
        public BaseRepository(MongoDbClient client)
        {
            _Context = client.GetContext();

            //Convention to name the collection the same as the base class. This will cause issues if we ever refactor.
            _Collection = _Context.GetCollection<T>(nameof(T));
        }

        void IBaseRepository<T>.Insert(T entity)
        {
            _Collection.InsertOne(entity);
        }

        void IBaseRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
        
        T IBaseRepository<T>.GetByID(int id)
        {
            var result = _Collection.Find(m => m.Id == id);
            return result.First();
        }

        void IBaseRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
