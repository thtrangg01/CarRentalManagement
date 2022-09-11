using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PaymentDAO : BaseDAO<Payment>
    {
        public override int Delete(Payment obj)
        {
            try
            {
                using var db = new AppDbContext();
                db.Payments.Attach(obj);
                db.Payments.Remove(obj);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override List<Payment> GetAll()
        {
            using var db = new AppDbContext();
            return db.Payments.ToList();
        }

        public override Payment GetById(int id)
        {
            using var db = new AppDbContext();
            return db.Payments.Find(id);
        }

        public override Payment Insert(Payment obj)
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

        public override int Update(Payment obj)
        {

            try
            {
                using var db = new AppDbContext();
                db.Payments.Attach(obj);
                db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
