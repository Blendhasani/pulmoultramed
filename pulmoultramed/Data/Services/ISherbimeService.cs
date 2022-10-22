using pulmoultramed.Data.ViewComponents;
using pulmoultramed.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pulmoultramed.Data.Services
{
    public interface ISherbimeService
    {
        Task AddNewSherbim(NewSherbimeVM sherb);
        Task<IEnumerable<Sherbimet>> GetAllAsync();

        Task UpdateAsync (int id,Sherbimet sherbimet);
        Task<Sherbimet> GetByIdAsync(int id);

      

        Task DeleteAsync(int id);
    }
}
