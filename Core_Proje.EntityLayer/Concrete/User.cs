﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.EntityLayer.Concrete
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

        //kullanıcının durumu başta onaysız olucak.
        public bool Status { get; set; } = false;
        public List<UserMessage> UserMessages { get; set; }

    }
}
