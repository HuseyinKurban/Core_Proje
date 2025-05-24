using Core_Proje.BusinessLayer.Abstract;
using Core_Proje.DataAccessLayer.Abstract;
using Core_Proje.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        private readonly IToDoListDal _toDoListDal;
        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void TAdd(ToDoList entity)
        {
            _toDoListDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _toDoListDal.Delete(id);
        }

        public ToDoList TGetById(int id)
        {
            return _toDoListDal.GetById(id);
        }

        public List<ToDoList> TGetList()
        {
           return _toDoListDal.GetList();
        }

        public void TUpdate(ToDoList entity)
        {
           _toDoListDal.Update(entity);
        }
    }      
    
}
