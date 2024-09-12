using Cars_rental.Repository.IRepository;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using Cars_rental.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using Cars_rental.Data;

namespace Cars_rental.Repository
{
    public class UnitOfWork : IUnitOfWork
    { 
        private AppDbContext _db;
        public ICar car { get; private set; }

        public ILocation Location { get; private set; }

        public IPayment Payment { get; private set; }

        public IRental Rental { get; private set; }

        public IUser User { get; private set; }


        public UnitOfWork(AppDbContext db)
        {
            _db = db;



        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
