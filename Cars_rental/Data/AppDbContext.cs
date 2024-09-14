using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace Cars_rental.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; init; }
        public DbSet<Rental> Rentals { get; init; }
        public DbSet<Location> Locations { get; init; }
        public DbSet<Payment> Payments { get; init; }
        public DbSet<Review> Reviews { get; init; }
        public DbSet<User> Users { get; init; }

        public AppDbContext(DbContextOptions options) : base(options)
        {       
                
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Car>() ;
            modelBuilder.Entity<Location>();
            modelBuilder.Entity<Payment>();
            modelBuilder.Entity<Rental>();
            modelBuilder.Entity<Review>();
            modelBuilder.Entity<User>();
        }

        

        

    }
}
