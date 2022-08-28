using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T t)
        {
            _object.Remove(t);
            c.SaveChanges();
        }

        public List<T> GelListAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetListAllById(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Inset(T t)
        {
            //c.Add(t);
            _object.Add(t);
            c.SaveChanges();
        }

        public List<T> TList(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }

        public void Update(T t)
        {
            //c.Update(t);
            _object.Update(t);
            c.SaveChanges();
        }
    }
}
