using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

[Collection("cars")]
public class Car
{
    
    public ObjectId Id { get; set; }

    [Required(ErrorMessage = "The number plate is required to identify the vehicle")]
    public string Make { get; set; }


    public string Model { get; set; }

    [Required(ErrorMessage = "The year is required to identify the vehicle")]
    public int Year { get; set; }

    public int Mileage { get; set; }


    public int Seats { get; set; }

    public string Type { get; set; }


    public string Fuel { get; set; }


    public string Transmission { get; set; }

    [Required(ErrorMessage = "The number plate is required to identify the vehicle")]
    [Display(Name = "Number Plate")]
    public string LicensePlate { get; set; }


    public ObjectId LocationId { get; set; }


    public RentalRate RentalRate { get; set; }


    public string Status { get; set; }


    public List<string> Features { get; set; }


    public List<MaintenanceHistory> MaintenanceHistory { get; set; } = new List<MaintenanceHistory>();
}

public class RentalRate
{

    public decimal Daily { get; set; }


    public decimal Weekly { get; set; }
}

public class MaintenanceHistory
{

    public DateTime Date { get; set; }

    public string Details { get; set; }
}
