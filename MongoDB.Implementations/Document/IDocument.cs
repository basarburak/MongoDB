using MongoDB.Bson;

namespace MongoDB.Implementations
{
	public interface IDocument
	{
		ObjectId Id { get; set; }
	}
}
