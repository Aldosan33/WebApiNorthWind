using System.Linq;
using Microsoft.EntityFrameworkCore;
using NorthWind.Api.Models;

namespace NorthWind.Api.Repository.MySql
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly NorthwindDbContext _context;
        public CustomerRepository(NorthwindDbContext context) : base(context)
        {
            _context = context;
        }

        public bool Exist(int id)
        {
            return _context.Customer.AsNoTracking().FirstOrDefault(c => c.Id == id) != null;
        }
    }
}