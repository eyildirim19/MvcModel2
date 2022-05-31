using Microsoft.AspNetCore.Mvc;

namespace MvcModel2.Controllers
{
    using Models;
    public class KullaniciController : Controller
    {
        //[HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost] // Post requestlerde tetiklensin. Actionlara yapılan requestler http reqest typleri ile yapılır... Action metotların default request type' GET'tir..
        public IActionResult Login(Kullanici kullanici)
        {

            return RedirectToAction("Index", "Home");
        }
    }
}
