using System.Collections.Generic;
using System.Threading.Tasks;

namespace pulmoultramed.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
        
    }
}
