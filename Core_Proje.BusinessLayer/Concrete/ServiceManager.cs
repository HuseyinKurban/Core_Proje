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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _serviceDal.Delete(id);
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
