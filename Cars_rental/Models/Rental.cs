using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Rental
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

    [BsonElement("location_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string LocationId { get; set; }

    [BsonElement("start_date")]
    public DateTime StartDate { get; set; }

    [BsonElement("end_date")]
    public DateTime EndDate { get; set; }

    [BsonElement("status")]
    public string Status { get; set; }

    [BsonElement("total_amount")]
    public decimal TotalAmount { get; set; }

    [BsonElement("payment_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string PaymentId { get; set; }
}
