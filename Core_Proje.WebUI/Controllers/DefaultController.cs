using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
