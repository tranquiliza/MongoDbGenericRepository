using GenericMongoDb.Core.Domain.TestEntities;

namespace GenericMongoDb.Core.Infrastructure
{
    public interface IGamerRepository : IBaseRepository<Gamer>
    {
        new void Update(Gamer entity);
    }
}
