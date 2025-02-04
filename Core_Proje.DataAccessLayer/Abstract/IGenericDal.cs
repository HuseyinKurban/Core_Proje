using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Proje.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T p);
        void Update(T p);
        void Delete(int id);
        List<T> GetList();
        T GetById(int id);
    }
}
