using Cars_rental.Data;
using Cars_rental.Repository.IRepository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Cars_rental.Repository
{
    public class CarRepository : ICar
    {
        public readonly IMongoDatabase _db;
        public CarRepository(IOptions<AppDbContext>  options  ) {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<Car> Cars =>
           _db.GetCollection<Car>("Car_Rental");

        public void Create(Car carData)
        {
            Cars.InsertOne(carData);
        }

        public void Delete(string _id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAllCars()
        {
            return Cars.Find(a => true).ToList();
        }

        public Car GetCarDetails(string _id)
        {
            var CarDetails=Cars.Find(a => a.Id==_id).FirstOrDefault();
            return CarDetails;
        }

        public void Update(string _id, Car carData)
        {
            
           /* var filtre = Builders<Car>.Filter.Eq(a => a.Id, _id);
            var update = Builders<Car>.Update
                .Set("", carData.Model);*/

        }
    }
}
