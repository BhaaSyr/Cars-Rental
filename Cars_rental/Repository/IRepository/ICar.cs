using MongoDB.Driver;

namespace Cars_rental.Repository.IRepository
{
    public interface ICar
    {
        IMongoCollection<Car> Cars { get; }
        IEnumerable<Car> GetAllCars();
        Car GetCarDetails(string _id);
        void Create(Car carData);
        void Update(string _id, Car carData);
        void Delete(string _id);

    }
}
