using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        AppDbContext db = new AppDbContext();
        public void Delete(T item)
        {
            db.Remove(item);
            db.SaveChanges();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return db.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            db.Add(item);
            db.SaveChanges();
        }

        public void Update(T item)
        {
            db.Update(item);
            db.SaveChanges();
        }
    }
}
