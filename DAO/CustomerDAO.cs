using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;

namespace DAO
{
    public class CustomerDAO : BaseDAO<Customer>
    {
        public override Customer GetById(int id)
        {
            using var db = new AppDbContext();
            return db.Customers.Find(id);
        }

        public override List<Customer> GetAll()
        {
            using var db = new AppDbContext();
            Console.WriteLine($"Read all data");
            return db.Customers.ToList();
        }

        public override Customer Insert(Customer customer)
        {
            try
            {
                using var db = new AppDbContext();

                db.Add(customer);
                db.SaveChanges();
                return customer;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override int Delete(Customer customer)
        {
            try
            {
                using var db = new AppDbContext();
                db.Customers.Attach(customer);
                db.Customers.Remove(customer);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override int Update(Customer obj)
        {
            try
            {
                using var db = new AppDbContext();
                db.Customers.Attach(obj);
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
