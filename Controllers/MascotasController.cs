using Microsoft.AspNetCore.Mvc;
using PetCare.Data;
using PetCare.Models;

namespace PetCare.Controllers
{
    public class MascotasController : Controller
    {
        public IActionResult Index()
        {
            var mascotas = PetsRepo.GetAllPets();
            return View();
        }
    }
}
