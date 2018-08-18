using MongoDB.Driver;

namespace MongoDB.Implementations
{
    public interface IMongoContext
    {
        IMongoDatabase Database { get; }
    }
}
