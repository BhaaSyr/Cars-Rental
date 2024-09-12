using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

public class Car
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("make")]
    public string Make { get; set; }

    [BsonElement("model")]
    public string Model { get; set; }

    [BsonElement("year")]
    public int Year { get; set; }

    [BsonElement("mileage")]
    public int Mileage { get; set; }

    [BsonElement("seats")]
    public int Seats { get; set; }

    [BsonElement("type")]
    public string Type { get; set; }

    [BsonElement("fuel")]
    public string Fuel { get; set; }

    [BsonElement("transmission")]
    public string Transmission { get; set; }

    [BsonElement("license_plate")]
    public string LicensePlate { get; set; }

    [BsonElement("location_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string LocationId { get; set; }

    [BsonElement("rental_rate")]
    public RentalRate RentalRate { get; set; }

    [BsonElement("status")]
    public string Status { get; set; }

    [BsonElement("features")]
    public List<string> Features { get; set; }

    [BsonElement("maintenance_history")]
    public List<MaintenanceHistory> MaintenanceHistory { get; set; } = new List<MaintenanceHistory>();
}

public class RentalRate
{
    [BsonElement("daily")]
    public decimal Daily { get; set; }

    [BsonElement("weekly")]
    public decimal Weekly { get; set; }
}

public class MaintenanceHistory
{
    [BsonElement("date")]
    public DateTime Date { get; set; }

    [BsonElement("details")]
    public string Details { get; set; }
}
