using BUS;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CarDAO : BaseDAO<CarEntity>
    {
        public override int Delete(CarEntity obj)
        {
            throw new NotImplementedException();
        }

        public override List<CarEntity> GetAll()
        {
            using var db = new AppDbContext();
            var cars = db.Cars.ToList();

            // Get Product of each car
            cars.ForEach(car =>
            {
                var entry = db.Entry(car);
                entry.Reference(c => c.Product).Load();
                entry.Reference(c => c.PickUpCheckList).Load();
                entry.Collection(c => c.RentalPrices).Load();

                var productEntry = db.Entry(car.Product);
                productEntry.Reference(p => p.Manufacturer).Load();

                var checkList = db.Entry(car.PickUpCheckList);
                checkList.Collection(cl => cl.CheckListItems).Load();
            });

            return cars;
        }

        public override CarEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override CarEntity Insert(CarEntity obj)
        {
            try
            {
                using var db = new AppDbContext();
                db.Attach(obj.Product);
                db.Add(obj);
                db.SaveChanges();
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override int Update(CarEntity obj)
        {
            try
            {
                using var db = new AppDbContext();
                db.Attach(obj.Product);
                db.Update(obj);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CarEntity GetLastCar()
        {
            using var db = new AppDbContext();
            var car = db.Cars.OrderByDescending(c => c.Number).FirstOrDefault();

            var entry = db.Entry(car);
            entry.Reference(c => c.Product).Load();

            var productEntry = db.Entry(car.Product);
            productEntry.Reference(p => p.Manufacturer).Load();
            return car;
        }

        public List<CarEntity> SearchCar(string textSearch, DateTime startDate, DateTime endDate)
        {
            using var db = new AppDbContext();

            var cars = from car in db.Cars
                       .Include(c => c.RentalPrices)
                       .Include(c => c.Product)
                       .ThenInclude(p => p.Manufacturer)
                       .Where(c => c.Number.Contains(textSearch) || c.Product.ProductCode.Contains(textSearch) || c.Product.Manufacturer.Name.Contains(textSearch)) 
                       join cd in db.ContractDetails on car.Id equals cd.CarId
                       into Details
                       from m in Details.DefaultIfEmpty()
                       where !(startDate <= m.EndDate && endDate >= m.StartDate) || m == null
                       select new CarEntity()
                       {
                           Id = car.Id,
                           Deleted = car.Deleted,
                           Number = car.Number,
                           Status = car.Status,
                           Cost = car.Cost,
                           Meter = car.Meter,
                           MeterUnit = car.MeterUnit,
                           InsuranceOn = car.InsuranceOn,
                           ProductId = car.ProductId,
                           PickUpCheckListId = car.PickUpCheckListId,
                           ReturnCheckListId = car.ReturnCheckListId,
                           OvertimeRate = car.OvertimeRate,
                           RequireCheckList = car.RequireCheckList,
                           Year = car.Year,
                           LicensePlates = car.LicensePlates,
                           Resreved = car.Resreved,
                           Product = car.Product,
                           RentalPrices = car.RentalPrices
                       };

            return cars.DistinctBy(c => c.Number).ToList();
        }
    }
}
