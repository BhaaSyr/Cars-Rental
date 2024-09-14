using Cars_rental.Data;
using Cars_rental.Repository.IRepository;

namespace Cars_rental.Repository
{
    public class LocationRepository :ILocation
    {

        private AppDbContext _db;
        public LocationRepository(AppDbContext db) 
        {
            _db = db;
        }

        public void Update(Location obj)
        {
            throw new NotImplementedException();
        }
    }
}
