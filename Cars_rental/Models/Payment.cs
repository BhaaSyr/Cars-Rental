using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;
using System;

[Collection("payments")]
public class Payment
{

    public ObjectId Id { get; set; }


    public ObjectId RentalId { get; set; }


    public ObjectId UserId { get; set; }


    public decimal Amount { get; set; }


    public string PaymentMethod { get; set; }


    public DateTime PaymentDate { get; set; }


    public string Status { get; set; }
}
