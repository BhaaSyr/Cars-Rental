using Cars_rental.Data;
using Cars_rental.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Misc;

namespace Cars_rental.Repository
{
    public class CarRepository : ICar
    {
        private AppDbContext _db;
       
        public CarRepository(AppDbContext db) 
        {
            _db = db;
            
        }

        public void AddCar(Car newCar)
        {
            _db.Cars.Add(newCar);

            _db.ChangeTracker.DetectChanges();
            Console.WriteLine(_db.ChangeTracker.DebugView.LongView);

            _db.SaveChanges();
        }

        public void DeleteCar(Car carToDelete)
        {
            var carDelete = _db.Cars.Where(c => c.Id == carToDelete.Id).FirstOrDefault();

            if (carToDelete != null)
            {
                _db.Cars.Remove(carToDelete);

                _db.ChangeTracker.DetectChanges();
                Console.WriteLine(_db.ChangeTracker.DebugView.LongView);

                _db.SaveChanges();
            }
            else
            {
                throw new ArgumentException("The car to delete cannot be found.");
            }
        }

        public void UpdateCar(Car updatedCar)
        {
            var carToUpdate = _db.Cars.FirstOrDefault(c => c.Id == updatedCar.Id);

            if (carToUpdate != null)
            {

                carToUpdate.Model = updatedCar.Model;
                carToUpdate.RentalRate = updatedCar.RentalRate;
                carToUpdate.LicensePlate = updatedCar.LicensePlate;
                carToUpdate.Features = updatedCar.Features;
                carToUpdate.Fuel = updatedCar.Fuel;
                carToUpdate.LocationId = updatedCar.LocationId;
                carToUpdate.Make = updatedCar.Make;
                carToUpdate.Mileage = updatedCar.Mileage;
                carToUpdate.Seats = updatedCar.Seats;
                carToUpdate.Status = updatedCar.Status;
                carToUpdate.Transmission = updatedCar.Transmission;
                carToUpdate.Type = updatedCar.Type;
                carToUpdate.Year = updatedCar.Year;
                carToUpdate.MaintenanceHistory = updatedCar.MaintenanceHistory;
                
                    
               
                
                _db.Cars.Update(carToUpdate);

                _db.ChangeTracker.DetectChanges();
                Console.WriteLine(_db.ChangeTracker.DebugView.LongView);

                _db.SaveChanges();

            }
            else
            {
                throw new ArgumentException("The car to update cannot be found. ");
            }
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _db.Cars.OrderBy(c => c.Id).AsNoTracking().AsEnumerable();
        }

        public Car? GetCarById(ObjectId id)
        {
            return _db.Cars.FirstOrDefault(c => c.Id == id);
        }

       


      
    }
}
