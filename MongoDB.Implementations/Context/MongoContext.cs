using MongoDB.Driver;

namespace MongoDB.Implementations
{
	public abstract class MongoContext : IMongoContext
	{
		protected MongoContext(string connectionString)
		{
			Database = new MongoClient(connectionString).GetDatabase(new MongoUrl(connectionString).DatabaseName);
		}

		public IMongoDatabase Database { get; }
	}
}
