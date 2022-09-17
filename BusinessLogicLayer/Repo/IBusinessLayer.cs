using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.DTO;
using DataAccessLayer.NHibernate;

namespace BusinessLogicLayer.Repo
{
    public interface IBusinessLayer
    {
        IEnumerable<Employees> GetEmployees();
        Employees GetEmployee( int id);
        void Create(Employees model);
        void Update(int id, Employees model);
        void Delete(int id);
    }
}
