using Core_Proje.BusinessLayer.Concrete;
using Core_Proje.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.WebUI.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager todolistManager= new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = todolistManager.TGetList();
            return View(values);
        }
    }
}
