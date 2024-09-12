using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Cars_rental.Models
{
    public class Review
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("user_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        [BsonElement("car_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CarId { get; set; }

        [BsonElement("review_date")]
        public DateTime ReviewDate { get; set; }

        [BsonElement("comment")]
        public string Comment { get; set; }

        [BsonElement("satrs")]
        public int Stars { get; set; }
    }
}
