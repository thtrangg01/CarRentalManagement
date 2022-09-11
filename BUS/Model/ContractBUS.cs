using BUS.Mapper;
using DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Model
{
    public class ContractBUS
    {
        private static ContractDAO dao;

        static ContractBUS()
        {
            dao = new ContractDAO();
        }

        public static List<Contract> GetAll()
        {
            return dao.GetAll().Select(c => c.ToModel()).ToList();
        }
        public static ContractEntity Insert(Contract contract)
        {
            return dao.Insert(contract.ToEntity());
        }
    }
}
