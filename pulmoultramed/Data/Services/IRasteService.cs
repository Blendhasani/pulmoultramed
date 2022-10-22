using pulmoultramed.Data.ViewComponents;
using pulmoultramed.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pulmoultramed.Data.Services
{
    public interface IRasteService
    {

        Task AddNewRast(NewRasteVM newRaste);
        Task <IEnumerable<Rastet>> GetAllAsync();

        Task UpdateAsync(int id, Rastet newRast);

        Task DeleteAsync(int id);
        Task<Rastet> GetByIdAsync(int id);

    }
}
