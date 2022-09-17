using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NHibernate
{
    public class EmpDetails
    {
        public virtual int DetailId { get; set; }
        public virtual string FatherName { get; set; }
        public virtual string Contact { get; set; }
        public virtual string Address { get; set; }
        public virtual int EmployeeId { get; set; }
      //  public virtual Employees Employees { get; set; }
    }
}
