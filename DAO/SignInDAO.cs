using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;

namespace DAO
{
    public class SignInDAO : BaseDAO<SignIn>
    {
        public override int Delete(SignIn obj)
        {
            try
            {
                using var db = new AppDbContext();
                db.SignIns.Attach(obj);
                db.SignIns.Remove(obj);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override List<SignIn> GetAll()
        {
            using var db = new AppDbContext();
            Console.WriteLine($"Read all data");
            return db.SignIns.ToList();
        }

        public override SignIn GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override SignIn Insert(SignIn obj)
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

        public override int Update(SignIn obj)
        {
            try
            {
                using var db = new AppDbContext();
                db.SignIns.Attach(obj);
                db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static SignInDAO instance;

        public static SignInDAO Instance
        {
            get { return instance ?? (instance = new SignInDAO()); }
            private set { instance = value; }
        }

        private SignInDAO() { }

        public bool Login(string username, string password)
        {
            string query = "select * from SignIn where BINARY_CHECKSUM(Username) = BINARY_CHECKSUM('{0}') and BINARY_CHECKSUM(Password) = BINARY_CHECKSUM('{1}') ";


            return false;
        }
    }
}
