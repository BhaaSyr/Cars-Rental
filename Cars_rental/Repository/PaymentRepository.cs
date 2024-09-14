using Cars_rental.Data;
using Cars_rental.Repository.IRepository;

namespace Cars_rental.Repository
{
    public class PaymentRepository : IPayment
    {

        private AppDbContext _db;
        public PaymentRepository(AppDbContext db) 
        {
            _db = db;
        }

        public void Update(Payment obj)
        {
            throw new NotImplementedException();
        }
    }
}
