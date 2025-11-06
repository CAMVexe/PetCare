using Microsoft.AspNetCore.Mvc;

namespace PetCare.Controllers
{
    public class MascotasController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
