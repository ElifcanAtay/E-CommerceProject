using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public Food GetById(int id)
        {
            return _foodDal.GetById(id);
        }

        public List<Food> GetList()
        {
            return _foodDal.GelListAll();
        }

        public List<Food> GetListAllById(Expression<Func<Food, bool>> filter)
        {
            return _foodDal.GetListAllById(filter);
            //throw new NotImplementedException();

        }

        public List<T> GetListByCategory(string p)
        {
            //return _foodDal
            throw new NotImplementedException();
        }

        public void TAdd(Food t)
        {
            _foodDal.Inset(t);
        }

        public void TDelete(Food t)
        {
            _foodDal.Delete(t);
        }

        public void TUpdate(Food t)
        {
            _foodDal.Update(t);
        }
    }
}
