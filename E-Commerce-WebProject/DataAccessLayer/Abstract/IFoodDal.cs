using EntityLayer.Concrete;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IFoodDal:IGenericDal<Food>
    {
        //List<Food> TList(string p);
    }
}
