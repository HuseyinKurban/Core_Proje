using Core_Proje.DataAccessLayer.Abstract;
using Core_Proje.DataAccessLayer.Repository;
using Core_Proje.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.DataAccessLayer.EntityFramework
{
    public class EfAboutDal:GenericRepository<About>, IAboutDal
    {
    }
}
