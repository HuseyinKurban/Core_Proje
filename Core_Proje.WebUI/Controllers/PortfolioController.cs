using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.DataAccessLayer.EntityFramework;
using Core_Proje.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {

            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Listesi";

            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proje Ekleme";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            p.Status = true;
            p.Value = 0;
            p.Image1 = "";
            p.Image2 = "";
            p.Image3 = "";
            p.Image4 = "";

            
            portfolioManager.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
