using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Domain.Entities;

namespace BUS
{
    public class StaffBUS
    {
        private static StaffDAO dao;

        static StaffBUS()
        {
            dao = new StaffDAO();
        }

        public static List<Staff> GetAll()
        {
            return dao.GetAll();
        }

        public static Staff GetById(int id)
        {
            return (Staff)dao.GetById(id);
        }

        public static void Insert(Staff staff)
        {
            dao.Insert(staff);
        }

        public static void Update(Staff staff)
        {
            dao.Update(staff);
        }

        public static void Delete(Staff staff)
        {
            dao.Delete(staff);
        }

    }
}
