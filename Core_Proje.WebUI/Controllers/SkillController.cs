using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            var values = skillManager.TGetList();
            return View(values);
        }
    }
}
