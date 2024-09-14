using Cars_rental.Data;
using Cars_rental.Models;
using Cars_rental.Repository.IRepository;

namespace Cars_rental.Repository
{
    public class ReviewRepository :IReview
    {
        private AppDbContext _db;
        public ReviewRepository(AppDbContext db) 
        {
            _db = db;
        }

        public void Update(Review obj)
        {
            throw new NotImplementedException();
        }
    }
}
