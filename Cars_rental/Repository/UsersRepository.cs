using Cars_rental.Data;
using Cars_rental.Repository.IRepository;

namespace Cars_rental.Repository
{
    public class UsersRepository:  IUser
    {
        private AppDbContext _db;
        public UsersRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
