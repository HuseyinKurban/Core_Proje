using Core_Proje.BusinessLayer.Abstract;
using Core_Proje.DataAccessLayer.Abstract;
using Core_Proje.EntityLayer.Concrete;

namespace Core_Proje.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _contactDal.Delete(id);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
