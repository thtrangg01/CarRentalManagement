using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;

namespace DAO
{
    public class StaffDAO : BaseDAO<Staff>
    {
        public override int Delete(Staff staff)
        {
            try
            {
                using var db = new AppDbContext();
                db.Staffs.Attach(staff);
                db.Staffs.Remove(staff);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override List<Staff> GetAll()
        {
            using var db = new AppDbContext();
            Console.WriteLine($"Read all data");
            return db.Staffs.ToList();
        }

        public override Staff GetById(int id)
        {
            using var db = new AppDbContext();
            return db.Staffs.Find(id);
        }

        public override Staff Insert(Staff staff)
        {
            try
            {
                using var db = new AppDbContext();

                db.Add(staff);
                db.SaveChanges();
                return staff;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override int Update(Staff staff)
        {
            try
            {
                using var db = new AppDbContext();
                db.Staffs.Attach(staff);
                db.Entry(staff).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
