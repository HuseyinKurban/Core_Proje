using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.ViewComponents.Dashboard
{
    public class OpenProjectLast5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}