using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("name")]
    public Name Name { get; set; }

    [BsonElement("email")]
    public string Email { get; set; }

    [BsonElement("phone")]
    public string Phone { get; set; }

    [BsonElement("driver_license")]
    public DriverLicense DriverLicense { get; set; }

    [BsonElement("rental_history")]
    public List<RentalHistory> RentalHistory { get; set; } = new List<RentalHistory>();

    [BsonElement("payment_methods")]
    public List<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
}

public class Name
{
    [BsonElement("first")]
    public string First { get; set; }

    [BsonElement("last")]
    public string Last { get; set; }
}

public class DriverLicense
{
    [BsonElement("number")]
    public string Number { get; set; }

    [BsonElement("issue_date")]
    public DateTime IssueDate { get; set; }

    [BsonElement("expiry_date")]
    public DateTime ExpiryDate { get; set; }
}

public class RentalHistory
{
    [BsonElement("rental_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string RentalId { get; set; }

    [BsonElement("car_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string CarId { get; set; }

    [BsonElement("start_date")]
    public DateTime StartDate { get; set; }

    [BsonElement("end_date")]
    public DateTime EndDate { get; set; }

    [BsonElement("total_amount")]
    public decimal TotalAmount { get; set; }
}

public class PaymentMethod
{
    [BsonElement("type")]
    public string Type { get; set; }

    [BsonElement("card_number")]
    public string CardNumber { get; set; }

    [BsonElement("expiry_date")]
    public DateTime ExpiryDate { get; set; }
}
