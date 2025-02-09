
using Core_Proje.BusinessLayer.Abstract;
using Core_Proje.DataAccessLayer.Abstract;
using Core_Proje.DataAccessLayer.EntityFramework;
using Core_Proje.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {

     private readonly IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience entity)
        {
            _experienceDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _experienceDal.Delete(id);
        }

        public Experience TGetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
