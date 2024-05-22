﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BackComandaBar.Models
{
    public class CardModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? NameClient { get; set; }
        public List<ProductModel>? Products { get; set; }
        public double TotalPrice { get; set; }
    }
}
