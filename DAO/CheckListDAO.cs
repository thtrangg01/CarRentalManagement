using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CheckListDAO : BaseDAO<CheckList>
    {
        public override int Delete(CheckList obj)
        {
            throw new NotImplementedException();
        }

        public override List<CheckList> GetAll()
        {
            using var db = new AppDbContext();
            return db.CheckLists.ToList();
        }

        public override CheckList GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override CheckList Insert(CheckList obj)
        {
            throw new NotImplementedException();
        }

        public override int Update(CheckList obj)
        {
            throw new NotImplementedException();
        }
    }
}
