using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Domain.Entities;

namespace BUS
{
    public class CustomerBUS
    {
        private static CustomerDAO dao;

        static CustomerBUS()
        {
            dao = new CustomerDAO();
        }

        public static List<Customer> GetAll()
        {
            return dao.GetAll();
        }

        public static Customer GetById(int id)
        {
            return (Customer)dao.GetById(id);
        }

        public static void Insert(Customer customer)
        {
            dao.Insert(customer);
        }

        public static void Update(Customer customer)
        {
            dao.Update(customer);
        }

        public static void Delete(Customer customer)
        {
            dao.Delete(customer);
        }
    }
}
