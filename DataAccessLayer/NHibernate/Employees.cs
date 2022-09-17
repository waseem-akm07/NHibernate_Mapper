using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NHibernate
{
    public class Employees
    {
        public virtual int EmployeeId { get; set; }
        public virtual string EmployeeName { get; set; }
        public virtual string EmployeeSalary { get; set; }
         public virtual ISet<EmpDetails> EmpDetails { get; set; }
       
    }
}
