using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.BusinessLayer.ValidationRules;
using Core_Proje.DataAccessLayer.EntityFramework;
using Core_Proje.EntityLayer.Concrete;
using FluentValidation.Results;
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

            PortfolioValidator validations = new PortfolioValidator();
            ModelState.Clear();
            ValidationResult results = validations.Validate(p);
            
            if(results.IsValid)
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeletePortfolio(int id)
        {
            portfolioManager.TDelete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.v1 = "Proje Güncelleme";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Güncelleme";
            var values=portfolioManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio p)
        {
            p.Status = true;


            
            PortfolioValidator validations = new PortfolioValidator();
            ModelState.Clear();
            ValidationResult results = validations.Validate(p);

            if (results.IsValid)
            {
                portfolioManager.TUpdate(p);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(p);
        }
    }
}
