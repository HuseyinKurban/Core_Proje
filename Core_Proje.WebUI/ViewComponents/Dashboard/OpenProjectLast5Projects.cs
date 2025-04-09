using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.ViewComponents.Dashboard
{
    public class OpenProjectLast5Projects : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            var deger=values.OrderByDescending(x=>x.PortfolioId).Take(5).ToList();
            return View(deger);
        }
    }

}