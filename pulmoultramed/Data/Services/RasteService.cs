using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using pulmoultramed.Data.ViewComponents;
using pulmoultramed.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pulmoultramed.Data.Services
{
    public class RasteService : IRasteService
    {

        private AppDbContext _context;
        public RasteService (AppDbContext context)
        {
            _context = context;
        }
        public async Task AddNewRast(NewRasteVM newRaste)
        {

            var newRast = new Rastet()
            {
                Emri = newRaste.Emri,
                Pershkrimi = newRaste.Pershkrimi,
                FotoUrl = newRaste.FotoUrl,
            };

            await _context.AddAsync(newRast);
            await _context.SaveChangesAsync();  

          
        }

        public async Task DeleteAsync(int id)
        {
            var rasti = await _context.Set<Rastet>().FirstOrDefaultAsync(x=>x.Id == id);
            EntityEntry entityEntry = _context.Entry(rasti);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
           
        }

        public async Task<IEnumerable<Rastet>> GetAllAsync()
        {
            var rastet = await _context.Set<Rastet>().ToListAsync();
            return rastet;

        }

        public async Task<Rastet> GetByIdAsync(int id)
        {
           var rasti = await _context.Set<Rastet>().FirstOrDefaultAsync(n=>n.Id == id);
            return rasti;
        }

        public async Task UpdateAsync(int id, Rastet newRast)
        {
            EntityEntry entityEntry = _context.Entry<Rastet>(newRast);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

     
    }
}
