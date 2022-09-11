using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;

namespace DAO
{
    public class ManufacturerDAO : BaseDAO<Manufacturer>
    {
        public override int Delete(Manufacturer manufacturer)
        {
            try
            {
                using var db = new AppDbContext();
                db.Manufacturers.Attach(manufacturer);
                db.Manufacturers.Remove(manufacturer);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override List<Manufacturer> GetAll()
        {
            using var db = new AppDbContext();
            Console.WriteLine($"Read all data");
            return db.Manufacturers.ToList();
        }

        public override Manufacturer GetById(int id)
        {
            using var db = new AppDbContext();
            return db.Manufacturers.Find(id);
        }

        public override Manufacturer Insert(Manufacturer manufacturer)
        {
            try
            {
                using var db = new AppDbContext();

                db.Add(manufacturer);
                db.SaveChanges();
                return manufacturer;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override int Update(Manufacturer manufacturer)
        {
            try
            {
                using var db = new AppDbContext();
                db.Manufacturers.Attach(manufacturer);
                db.Entry(manufacturer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
