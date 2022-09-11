using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RentalPriceDAO : BaseDAO<RentalPrice>
    {
        public override int Delete(RentalPrice obj)
        {
            throw new NotImplementedException();
        }

        public override List<RentalPrice> GetAll()
        {
            throw new NotImplementedException();
        }

        public override RentalPrice GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override RentalPrice Insert(RentalPrice obj)
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

        public override int Update(RentalPrice obj)
        {
            throw new NotImplementedException();
        }
    }
}
