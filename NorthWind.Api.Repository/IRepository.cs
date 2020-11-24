using System.Collections.Generic;

namespace NorthWind.Api.Repository
{
    public interface IRepository<T> where T : class
    {
        int Create(T entity);
        bool Update(T entity);
        IEnumerable<T> ReadAll();
        T Read(int id);
        bool Delete(T entity);
    }
}