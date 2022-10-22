using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using pulmoultramed.Data.Base;
using pulmoultramed.Data.ViewComponents;
using pulmoultramed.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pulmoultramed.Data.Services
{
    public class SherbimeService : ISherbimeService
    {
        private readonly AppDbContext _context;
    public SherbimeService(AppDbContext context)
    {
        _context = context;
    }

        public async Task AddNewSherbim(NewSherbimeVM sherb)
        {
            var newSherbim = new Sherbimet()
            {
                Emri = sherb.Emri,
                Pershkrimi = sherb.Pershkrimi,
                FotoUrl = sherb.FotoUrl
            };
           await _context.AddAsync(newSherbim);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var entity = await _context.Set<Sherbimet>().FirstOrDefaultAsync(x=>x.Id == id);
            EntityEntry entry = _context.Entry<Sherbimet>(entity);
            entry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Sherbimet>> GetAllAsync()
        {
            var result = await _context.Set<Sherbimet>().ToListAsync();
            return result;
        }

        public async Task<Sherbimet> GetByIdAsync(int id)
        {
            var result = await _context.Set<Sherbimet>().FirstOrDefaultAsync(n=>n.Id == id);
            return result;
        }

        public async Task UpdateAsync(int id, Sherbimet sherbimet)
        {
            EntityEntry entityEntry = _context.Entry<Sherbimet>(sherbimet);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
