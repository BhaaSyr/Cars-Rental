using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;


[Collection("reviews")]
public class Review
    {

        public ObjectId Id { get; set; }


        public ObjectId UserId { get; set; }


        public ObjectId CarId { get; set; }


        public DateTime ReviewDate { get; set; }

        public string? Comment { get; set; }


        public int Stars { get; set; }
    }

