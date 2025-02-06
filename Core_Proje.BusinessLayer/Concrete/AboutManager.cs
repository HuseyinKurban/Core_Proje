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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About entity)
        {
           _aboutDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _aboutDal.Delete(id);
        }

        public About TGetById(int id)
        {
           return _aboutDal.GetById(id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
