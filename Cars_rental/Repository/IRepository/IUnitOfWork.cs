using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Cars_rental.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICar car { get; }
        ILocation Location { get; }
        IPayment Payment { get; }
        IRental Rental { get; }
        IUser User { get; }
  

        void Save();
    }
}
