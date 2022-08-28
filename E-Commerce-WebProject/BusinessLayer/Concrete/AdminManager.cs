using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.GelListAll();
        }

        public List<Admin> GetListAllById(Expression<Func<Admin, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetListAllById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Admin t)
        {
            _adminDal.Inset(t);
        }

        public void TDelete(Admin t)
        {
            _adminDal.Delete(t);
        }

        public void TUpdate(Admin t)
        {
            _adminDal.Update(t);
        }

    }
}
