using BUS.Model;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Mapper
{
    public static class ContractMapper
    {

        public static Contract ToModel(this ContractEntity contract)
        {
            var dto = contract;
           
            
            return new Contract()
            {
                Number = dto.Number,
                Status = dto.Status,
                InvoiceDate = dto.InvoiceDate,
                PaymentDate = dto.PaymentDate,
                Discount = (decimal)dto.Discount,
                PercentDiscount = (double)dto.PercentDiscount,
                Tax = (decimal)dto.Tax,
                Creator = dto.Creator,
                CompleteBy = dto.CompleteBy,
                Customer = dto.Customer,
                Subtotal = dto.Subtotal,
                CustomerId = dto.CustomerId,
                RentalAgreement = dto.RentalAgreement,
                RentalCondition = dto.RentalCondition,
            };
        }

        public static ContractEntity ToEntity(this Contract contract)
        {
            var model = contract;
            var entity = new ContractEntity()
            {
                Number = model.Number,
                Status = model.Status,
                InvoiceDate = model.InvoiceDate,
                PaymentDate = model.PaymentDate,
                Discount = model.Discount,
                PercentDiscount = model.PercentDiscount,
                Tax = model.Tax,
                Creator = model.Creator,
                CompleteBy = model.CompleteBy,
                Customer = model.Customer,
                Subtotal = model.Subtotal,
                CustomerId = model.CustomerId,
                RentalAgreement = model.RentalAgreement,
                RentalCondition = model.RentalCondition,
            };

            if (model.ContractDetails != null)
            {
                entity.ContractDetails = model.ContractDetails.Select(c => c.ToEntity()).ToList();
            }

            return entity;
        }
    }
}
