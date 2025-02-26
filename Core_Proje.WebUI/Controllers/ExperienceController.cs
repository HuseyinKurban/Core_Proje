using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.DataAccessLayer.EntityFramework;
using Core_Proje.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {

            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";

            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            experienceManager.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.v1 = "Deneyim Güncelleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            var value = experienceManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience p)
        {
            experienceManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
