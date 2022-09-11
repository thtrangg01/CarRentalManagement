using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public abstract class BaseDAO<T> where T : BaseEntity
    {
        public abstract T GetById(int id);
        public abstract List<T> GetAll();
        public abstract T Insert(T obj);
        public abstract int Delete(T obj);
        public abstract int Update(T obj);

        public T InsertV2(T obj)
        {
            try
            {
                using var db = new AppDbContext();
                db.Add(obj);
                db.SaveChanges();
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> InsertRange(List<T> objs)
        {
            try
            {
                using var db = new AppDbContext();
                db.AddRange(objs);
                db.SaveChanges();
                return objs;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
