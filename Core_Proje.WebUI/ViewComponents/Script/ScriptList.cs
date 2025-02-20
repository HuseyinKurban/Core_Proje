using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.ViewComponents.Script
{
    public class ScriptList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
