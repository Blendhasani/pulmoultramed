using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pulmoultramed.Data;
using System.Threading.Tasks;

namespace pulmoultramed.Controllers
{
    public class LogoController : Controller
    {
        private readonly AppDbContext _context;

        public LogoController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Logoja()
        {
            var logo = await _context.Logos.ToListAsync();
            return View(logo);
        }
    }
}
