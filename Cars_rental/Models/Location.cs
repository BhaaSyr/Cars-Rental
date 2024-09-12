using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

public class Location
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("address")]
    public Address Address { get; set; }

    [BsonElement("available_cars")]
    public List<string> AvailableCars { get; set; } = new List<string>();

    [BsonElement("phone")]
    public string Phone { get; set; }

    [BsonElement("working_hours")]
    public WorkingHours WorkingHours { get; set; }
}

public class Address
{
    [BsonElement("street")]
    public string Street { get; set; }

    [BsonElement("city")]
    public string City { get; set; }

    [BsonElement("state")]
    public string State { get; set; }

    [BsonElement("zip")]
    public string Zip { get; set; }
}

public class WorkingHours
{
    [BsonElement("open")]
    public string Open { get; set; }

    [BsonElement("close")]
    public string Close { get; set; }
}
