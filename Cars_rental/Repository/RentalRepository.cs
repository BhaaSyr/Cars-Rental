using Cars_rental.Data;
using Cars_rental.Repository.IRepository;

namespace Cars_rental.Repository
{
    public class RentalRepository : IRental
    {
        private AppDbContext _db;
        public RentalRepository(AppDbContext db) 
        {
            _db = db;
        }

        public void Update(Rental obj)
        {
            throw new NotImplementedException();
        }
    }
}
