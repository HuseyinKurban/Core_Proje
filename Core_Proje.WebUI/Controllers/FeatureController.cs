using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.DataAccessLayer.EntityFramework;
using Core_Proje.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Öne Çıkanlar";
            ViewBag.v2 = "Düzenleme ";
            ViewBag.v3 = "Öne Çıkan Sayfası";

            var values = featureManager.TGetById(1);
            return View(values);

        }
        [HttpPost]
        public IActionResult Index(Feature p)
        {
            ViewBag.v1 = "Öne Çıkanlar";
            ViewBag.v2 = "Düzenleme ";
            ViewBag.v3 = "Öne Çıkan Sayfası";

            featureManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
