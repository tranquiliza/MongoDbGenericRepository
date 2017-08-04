using System;
using GenericMongoDb.Core.Domain.TestEntities;
using GenericMongoDb.Core.Infrastructure;
using MongoDB.Driver;

namespace GenericMongoDb.Data.Repository
{
    public class GamerRepository : BaseRepository<Gamer>, IGamerRepository
    {
        public GamerRepository(MongoDbClient client) : base(client)
        {

        }

        public void Update(Gamer entity)
        {
            var filter = Builders<Gamer>.Filter.Eq(nameof(entity.Id), entity.Id);
            var update = Builders<Gamer>.Update.Set(nameof(entity.Name), entity.Name);

            _Collection.UpdateOne(filter, update);
        }
    }
}
