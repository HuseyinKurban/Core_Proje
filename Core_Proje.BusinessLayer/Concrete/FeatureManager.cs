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
    public class FeatureManager : IGenericService<Feature>
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature entity)
        {
            _featureDal.Insert(entity);
        }

        public void TDelete(int id)
        {
           _featureDal.Delete(id);
           
        }

        public Feature TGetById(int id)
        {
           return _featureDal.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature entity)
        {
             _featureDal.Update(entity);
        }
    }
}
