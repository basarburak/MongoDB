using MongoDB.Implementations;

namespace MongoDB.Database
{
    public sealed class Customer : Document
    {
        public string Name { get; set; }
    }
}
