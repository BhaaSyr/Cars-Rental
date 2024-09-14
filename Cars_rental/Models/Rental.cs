using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;
using System;

[Collection("rentals")]
public class Rental
{
    public ObjectId Id { get; set; }



    public ObjectId UserId { get; set; }


 
    public ObjectId CarId { get; set; }

    public ObjectId LocationId { get; set; }

    public DateTime StartDate { get; set; }


    public DateTime EndDate { get; set; }

    public string Status { get; set; }


    public decimal TotalAmount { get; set; }


    public ObjectId PaymentId { get; set; }
}
