using BUS.Mapper;
using BUS.Model;
using DAO;
using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CarBUS
    {
        private static CarDAO dao;
        private static CheckListDAO checkListDAO = new CheckListDAO();
        private static CheckListItemDAO checkListItemDAO =  new CheckListItemDAO();

        static CarBUS()
        {
            dao = new CarDAO();
        }

        public static List<Car> GetAll()
        {
            return dao.GetAll().Select(c => c.ToModel()).ToList();
        }

        public static CarEntity Insert(CarEntity carEntity)
        {
            return dao.Insert(carEntity);
        }

        public static int Update(CarEntity carEntity)
        {
            return dao.Update(carEntity);
        }

        public static Car GetLast()
        {
            return dao.GetLastCar().ToModel();
        }

        public static List<Car> SearchCar(string textSearch, DateTime startDate, DateTime endDate)
        {
            var cars = dao.SearchCar(textSearch, startDate, endDate).Select(c => c.ToModel()).ToList();
            //var carsNotMatch = new List<Car>();

            //cars.RemoveAll(c =>
            //{
            //    if (c.ContractDetails == null)
            //    {
            //        return false;
            //    }

            //    //(StartA <= EndB) and(EndA >= StartB)
            //    return c.ContractDetails.Any(cd => startDate <= cd.EndDate && endDate >= cd.StartDate);
            //});
            return cars;
        }
    }
}
