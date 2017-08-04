namespace GenericMongoDb.Core.Infrastructure
{
    public interface IUnitOfWork
    {
        IGamerRepository GamerRepository { get; }
    }
}
