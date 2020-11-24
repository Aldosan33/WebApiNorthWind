using NorthWind.Api.Models;

namespace NorthWind.Api.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        bool Exist(int id);
    }
}