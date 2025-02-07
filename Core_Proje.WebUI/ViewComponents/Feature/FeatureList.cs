using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
