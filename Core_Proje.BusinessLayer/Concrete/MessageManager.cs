using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_Proje.BusinessLayer.Abstract;
using Core_Proje.DataAccessLayer.Abstract;
using Core_Proje.EntityLayer.Concrete;

namespace Core_Proje.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message entity)
        {
            _messageDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _messageDal.Delete(id);
        }

        public Message TGetById(int id)
        {
           return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public void TUpdate(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}
