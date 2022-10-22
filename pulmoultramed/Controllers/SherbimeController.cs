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
    public class SherbimeController : Controller
    {

        private readonly ISherbimeService _service;



        public SherbimeController(ISherbimeService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allSherbimet = await _service.GetAllAsync();
            return View(allSherbimet);
        }

        public IActionResult Create()
        {
            return View("Create");
        }


        [HttpPost]
        public async Task<IActionResult> Create(NewSherbimeVM sherbime) {
            if (!ModelState.IsValid)
            {
                return View(sherbime);
            }
            await _service.AddNewSherbim(sherbime);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var sherbime = await _service.GetByIdAsync(id);
            if(sherbime == null)
            {
                return View("NotFound");
            }
            return View(sherbime);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id ,[Bind("Id,Emri,Pershkrimi,FotoUrl")] Sherbimet sherbime)
        {
            if (!ModelState.IsValid)
            {
                return View(sherbime);
            }
            await _service.UpdateAsync(id, sherbime);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            var sherbimi = await _service.GetByIdAsync(id);
            if (sherbimi == null) return View("NotFound");
            return View(sherbimi);
        }

        [HttpPost,ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var sherbimi = await _service.GetByIdAsync(id);
            if (sherbimi == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var sherbimi = await _service.GetByIdAsync(id);
            return View(sherbimi);
        }


    }
}
