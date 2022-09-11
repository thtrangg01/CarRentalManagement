using BUS.Model;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Mapper
{
    public static class CarMapper
    {
        public static Car ToModel(this CarEntity car)
        {
            var dto = car;
            if (dto.Product == null)
            {
                dto.Product = new Product();
            }
            if (dto.ContractDetails == null)
            {
                dto.ContractDetails = new List<ContractDetailEntity>();
            }
            return new Car()
            {
                Id = dto.Id,
                Deleted = dto.Deleted,
                Number = dto.Number,
                Status = dto.Status,
                Cost = dto.Cost,
                Meter = dto.Meter,
                MeterUnit = dto.MeterUnit,
                InsuranceOn = dto.InsuranceOn,
                ProductId = dto.ProductId,
                PickUpCheckListId = dto.PickUpCheckListId,
                ReturnCheckListId = dto.ReturnCheckListId,
                OvertimeRate = dto.OvertimeRate,
                RequireCheckList = dto.RequireCheckList,
                Year = dto.Year,
                LicensePlates = dto.LicensePlates,
                Resreved = dto.Resreved,
                Product = dto.Product,
                Manufacturer = dto.Product.Manufacturer,
                PickUpCheckList = dto.PickUpCheckList,
                ReturnCheckList = dto.ReturnCheckList,
                RentalPrices = dto.RentalPrices,
                //ContractDetails = dto.ContractDetails.Select(cd => cd.ToModel()).ToList()
            };
        }

        public static CarEntity ToEntity(this Car car)
        {
            var model = car;
            return new CarEntity()
            {
                Id = model.Id,
                Deleted = model.Deleted,
                Number = model.Number,
                Status = model.Status,
                Cost = model.Cost,
                Meter = model.Meter,
                MeterUnit = model.MeterUnit,
                InsuranceOn = model.InsuranceOn,
                ProductId = model.ProductId,
                PickUpCheckListId = model.PickUpCheckListId,
                ReturnCheckListId = model.ReturnCheckListId,
                OvertimeRate = model.OvertimeRate,
                RequireCheckList = model.RequireCheckList,
                Year = model.Year,
                LicensePlates = model.LicensePlates,
                Resreved = model.Resreved,
                Product = model.Product,
                PickUpCheckList = model.PickUpCheckList,
                ReturnCheckList = model.ReturnCheckList,
                RentalPrices = model.RentalPrices
            };
        }
    }
}
