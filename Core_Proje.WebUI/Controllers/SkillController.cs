using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.DataAccessLayer.EntityFramework;
using Core_Proje.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Listesi";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Listesi";

            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Yetenek Ekleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            skillManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            skillManager.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            ViewBag.v1 = "Yetenek Güncelleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelleme";
            var skillValue = skillManager.TGetById(id);
            return View(skillValue);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill p)
        {
            skillManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
