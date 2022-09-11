using BUS.Model;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Mapper
{
    public static class CarContractMapper
    {
        public static ContractDetail ToModel(this ContractDetailEntity contractDetailEntity)
        {
            var entity = contractDetailEntity;
            return new ContractDetail()
            {
                ContractId = entity.ContractId,
                CarId = entity.CarId,
                Car = entity.Car.ToModel(),
                Number = entity.Car.Number,
                CarName = entity.Car.Product.Manufacturer.Name + " " + entity.Car.Product.ProductCode,
                LicensePlates = entity.Car.LicensePlates,
                PickUpDate = entity.PickUpDate,
                ReturnDate = entity.ReturnDate,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                RentalPriceQties = entity.RentalPriceQties,
                PickUpCheckListId = entity.PickUpCheckListId,
                ReturnCheckListId = entity.ReturnCheckListId,
                CheckInDone = entity.CheckInDone,
                CheckOutDone = entity.CheckOutDone,
                RealMeter = entity.RealMeter,
                MeterLimit = entity.MeterLimit,
                Overtime = entity.Overtime,
                OvertimeRate = entity.OvertimeRate,
                Tax = entity.Tax,
                PercentTax = entity.PercentTax,
                Discount = entity.Discount,
                PercenDiscount = entity.PercenDiscount,
                Subtotal = entity.Subtotal
            };
        }

        public static ContractDetailEntity ToEntity(this ContractDetail contractDetail)
        {
            var entity = contractDetail;
            return new ContractDetailEntity()
            {
                ContractId = entity.ContractId,
                CarId = entity.CarId,
                Car = entity.Car.ToEntity(),
                PickUpDate = entity.PickUpDate,
                ReturnDate = entity.ReturnDate,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                RentalPriceQties = entity.RentalPriceQties,
                PickUpCheckListId = entity.PickUpCheckListId,
                ReturnCheckListId = entity.ReturnCheckListId,
                CheckInDone = entity.CheckInDone,
                CheckOutDone = entity.CheckOutDone,
                RealMeter = entity.RealMeter,
                MeterLimit = entity.MeterLimit,
                Overtime = entity.Overtime,
                OvertimeRate = entity.OvertimeRate,
                Tax = entity.Tax,
                PercentTax = entity.PercentTax,
                Discount = entity.Discount,
                PercenDiscount = entity.PercenDiscount,
                Subtotal = entity.Subtotal
            };
        }
    }
}
