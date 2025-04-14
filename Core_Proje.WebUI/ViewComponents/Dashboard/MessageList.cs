using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}

