using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;
using System;
using System.Collections.Generic;


[Collection("users")]
public class User
{
 
    public ObjectId Id { get; set; }

    public Name Name { get; set; }

    public string Email { get; set; }


    public string Phone { get; set; }


    public DriverLicense DriverLicense { get; set; }


    public List<RentalHistory> RentalHistory { get; set; } = new List<RentalHistory>();

    public List<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
}

public class Name
{

    public string First { get; set; }

    public string Last { get; set; }
}

public class DriverLicense
{

    public string Number { get; set; }

    public DateTime IssueDate { get; set; }


    public DateTime ExpiryDate { get; set; }
}

public class RentalHistory
{

    public ObjectId RentalId { get; set; }

  
    public ObjectId CarId { get; set; }

 
    public DateTime StartDate { get; set; }


    public DateTime EndDate { get; set; }


    public decimal TotalAmount { get; set; }
}

public class PaymentMethod
{

    public string Type { get; set; }

    public string CardNumber { get; set; }


    public DateTime ExpiryDate { get; set; }
}
