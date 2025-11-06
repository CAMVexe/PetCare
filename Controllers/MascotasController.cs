using Microsoft.AspNetCore.Mvc;
using PetCare.Data;
using PetCare.Models;

namespace PetCare.Controllers
{
    //GET
    public class MascotasController : Controller
    {
        public IActionResult Index()
        {
            var mascotas = PetsRepo.GetAllPets();
            return View(mascotas);
        }

        public IActionResult Create()
        {
            return View(new Mascota());
        }

        //POST
        [HttpPost]
        public IActionResult Create(Mascota model)
        {
            if (model.DateIn > DateTime.Today)
            {
                ModelState.AddModelError("DateIn", "La fecha de ingreso no puede ser futura");
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            PetsRepo.AddPet(model);

            TempData["Mensaje"] = $"Mascota {model.PetName} agregada correctamente";

            return RedirectToAction(nameof(Index));
        }
    }
}
