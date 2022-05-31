using Microsoft.AspNetCore.Mvc;

namespace MvcModel2.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        HaberRepository repo = new HaberRepository();

        // Controllerdan view'a veri gönderik...
        public IActionResult Index()
        {
            var list = repo.HaberList();
            return View(list);
        }
    }
}
