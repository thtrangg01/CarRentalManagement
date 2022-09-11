using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Domain.Entities;

namespace BUS
{
    public class ManufacturerBUS
    {
        private static ManufacturerDAO dao;

        static ManufacturerBUS()
        {
            dao = new ManufacturerDAO();
        }

        public static List<Manufacturer> GetAll()
        {
            return dao.GetAll();
        }

        public static Manufacturer GetById(int id)
        {
            return (Manufacturer) dao.GetById(id);
        }

        public static void Insert(Manufacturer manufacturer)
        {
            dao.Insert(manufacturer);
        }

        public static void Update(Manufacturer manufacturer)
        {
            dao.Update(manufacturer);
        }

        public static void Delete(Manufacturer manufacturer)
        {
            dao.Delete(manufacturer);
        }
    }
}
