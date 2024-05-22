using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BackComandaBar.Models
{
    public class ProductModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
