using Core_Proje.DataAccessLayer.Abstract;
using Core_Proje.DataAccessLayer.Concrete;
using Core_Proje.DataAccessLayer.Repository;
using Core_Proje.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.DataAccessLayer.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        public List<UserMessage> GetUserMessagesWithUser()
        {
            var c = new Context();
            return c.UserMessages.Include(x => x.User).ToList();


        }
    }
}
