using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ContractDAO : BaseDAO<ContractEntity>
    {
        public override int Delete(ContractEntity obj)
        {
            throw new NotImplementedException();
        }

        public override List<ContractEntity> GetAll()
        {
            using var db = new AppDbContext();
            var contracts = db.Contracts.ToList();

            return contracts;
        }

        public override ContractEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override ContractEntity Insert(ContractEntity contract)
        {
            try
            {
                using var db = new AppDbContext();
                db.Attach(contract.Creator);
                //db.Attach(contract.CompleteBy);
                db.Attach(contract.Customer);
                
                var contractDetail = contract.ContractDetails.FirstOrDefault();
                var car = db.Cars.Find(contractDetail.CarId);

                if (car == null)
                {
                    db.Attach(contractDetail.Car);
                } else
                {
                    db.Attach(car);
                }

                db.Contracts.Add(contract);

                db.SaveChanges();
                return contract;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override int Update(ContractEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
