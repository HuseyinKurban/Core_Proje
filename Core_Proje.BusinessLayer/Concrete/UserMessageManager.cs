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
    public class UserMessageManager : IUserMessageService
    {
     
        
       private readonly IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetUserMessagesWithUserService()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public void TUpdate(UserMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
