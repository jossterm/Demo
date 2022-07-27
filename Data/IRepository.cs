using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Data
{
    public interface IRepository
    {
        Task<int> CreateAsync<T>(T entity) where T : class;
        Task<List<T>> SelectAll<T>() where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
        Task<T> SelectById<T>(int Id) where T : class;    
        Task UpdateAsync<T>(T entity) where T : class;
        Task<List<T>> SelectByRange<T>(int pageNumber, int pagSize) where T : class;
    }
}
