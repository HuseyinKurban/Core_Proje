using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.DataAccessLayer.EntityFramework;
using Core_Proje.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımda";
            ViewBag.v2 = "Düzenleme ";
            ViewBag.v3 = "Hakkımda Sayfası";

            var values = aboutManager.TGetById(1);
            return View(values);

        }
        [HttpPost]
        public IActionResult Index(About p)
        {
            ViewBag.v1 = "Hakkımda";
            ViewBag.v2 = "Düzenleme ";
            ViewBag.v3 = "Hakkımda Sayfası";

            aboutManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
