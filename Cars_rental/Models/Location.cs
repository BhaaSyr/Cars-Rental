using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;
using System;
using System.Collections.Generic;

[Collection("locations")]
public class Location
{

    public ObjectId Id { get; set; }


    public string Name { get; set; }


    public Address Address { get; set; }

    public List<string> AvailableCars { get; set; } = new List<string>();

    public string Phone { get; set; }


    public WorkingHours WorkingHours { get; set; }
}

public class Address
{

    public string Street { get; set; }

  
    public string City { get; set; }


    public string State { get; set; }


    public string Zip { get; set; }
}

public class WorkingHours
{

    public string Open { get; set; }


    public string Close { get; set; }
}
