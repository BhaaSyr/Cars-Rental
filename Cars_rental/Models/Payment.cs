using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Payment
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("rental_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string RentalId { get; set; }

    [BsonElement("user_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string UserId { get; set; }

    [BsonElement("amount")]
    public decimal Amount { get; set; }

    [BsonElement("payment_method")]
    public string PaymentMethod { get; set; }

    [BsonElement("payment_date")]
    public DateTime PaymentDate { get; set; }

    [BsonElement("status")]
    public string Status { get; set; }
}
