using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace Cars_rental.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IMongoDatabase _database;
        public string ConnectionString {  get; set; }
        public string Database { get; set; }

        public IMongoCollection<User> Users => _database.GetCollection<User>("users");
        public IMongoCollection<Car> Cars => _database.GetCollection<Car>("cars");
        public IMongoCollection<Rental> Rentals => _database.GetCollection<Rental>("rentals");
        public IMongoCollection<Payment> Payments => _database.GetCollection<Payment>("payments");
        public IMongoCollection<Location> Locations => _database.GetCollection<Location>("locations");
        
    }
}
