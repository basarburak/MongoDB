using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Implementations
{
    public abstract class Document : IDocument
    {
        [BsonExtraElements]
        public BsonDocument ExtraElements { get; set; }

        public ObjectId Id { get; set; }
    }
}
