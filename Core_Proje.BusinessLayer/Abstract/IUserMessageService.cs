﻿using Core_Proje.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.BusinessLayer.Abstract
{
    public interface IUserMessageService:IGenericService<UserMessage>
    {
        List<UserMessage> GetUserMessagesWithUserService();
       
    }
}
