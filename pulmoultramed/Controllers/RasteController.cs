using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using pulmoultramed.Data.Services;
using pulmoultramed.Data.Static;
using pulmoultramed.Data.ViewComponents;
using pulmoultramed.Models;
using System.Threading.Tasks;

namespace pulmoultramed.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class RasteController : Controller
    {

        private readonly IRasteService _rasteService;

        public RasteController(IRasteService rasteService)
        {
            _rasteService = rasteService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var rastet = await _rasteService.GetAllAsync();
            return View(rastet);
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewRasteVM newRaste)
        {
            if (!ModelState.IsValid)
            {
                return View(newRaste);
            }
            await _rasteService.AddNewRast(newRaste);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit( int id)
        {

            var rasti = await _rasteService.GetByIdAsync(id);
            if(rasti == null)
            {
                return View("NotFound");
            }
            return View(rasti);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Emri,Pershkrimi,FotoUrl")] Rastet newRaste)
        {
            if (!ModelState.IsValid)
            {
                return View(newRaste);
            }
            await _rasteService.UpdateAsync(id, newRaste);
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int id)
        {
            var rasti = await _rasteService.GetByIdAsync(id);
            if(rasti == null)
            {
                return View("NotFound");
            }
            return View(rasti);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rasti = await _rasteService.GetByIdAsync(id);
            if (rasti == null)
            {
                return View("NotFound");
            }
            await _rasteService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var rasti = await _rasteService.GetByIdAsync(id);
            return View(rasti);
        }
    }
}
