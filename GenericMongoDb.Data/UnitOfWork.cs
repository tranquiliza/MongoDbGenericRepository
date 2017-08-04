using System;
using GenericMongoDb.Core.Infrastructure;
using GenericMongoDb.Data.Repository;

namespace GenericMongoDb.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private MongoDbClient _Client;

        public UnitOfWork(MongoDbClient client)
        {
            _Client = client;
        }

        IGamerRepository IUnitOfWork.GamerRepository => new GamerRepository(_Client);
    }
}
