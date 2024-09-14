using MongoDB.Bson;
using MongoDB.Driver;

namespace Cars_rental.Repository.IRepository
{
    public interface ICar
    {
       
        IEnumerable<Car> GetAllCars();
        Car? GetCarById(ObjectId id);

        void AddCar(Car newCar);

        void UpdateCar(Car updatedCar);

        void DeleteCar(Car carToDelete);


    }
}
