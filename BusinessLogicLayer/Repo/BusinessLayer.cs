using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.NHibernate;
using DataTransferObject.DTO;
using NHibernate;
using NHibernate.Linq;


namespace BusinessLogicLayer.Repo
{
    public class BusinessLayer : IBusinessLayer
    {
        public Employees GetEmployee(int id)
        {
            Employees employee = null;
            using (ISession session = OpenNHibertnateSession.OpenSession())
            {
               //  IEnumerable<Employees> employee = new List<Employees>();
              //    employee = session.Query<Employees>().Where(x=>x.EmployeeId == id).ToList();

                 employee = session.Get<Employees>(id);

                NHibernateUtil.Initialize(employee.EmpDetails);

                return employee;
            }
        }

        public IEnumerable<Employees> GetEmployees()
        {

            IEnumerable<Employees> employee = new List<Employees>();
            using (ISession session = OpenNHibertnateSession.OpenSession())
            {
               
                employee = session.Query<Employees>().ToList();

                // Employees employees = null;
                // ICriteria targetObjects = session.CreateCriteria(typeof(Employees));
                // IList<Employees> itemList = targetObjects.List<Employees>();
                // fromdb = session.Query<Employees>().ToList();
                //  NHibernateUtil.Initialize(employee);
                Console.WriteLine(employee);
                return employee;
                               
            }
        }

        public void Create(Employees model)
        {
            using(ISession session = OpenNHibertnateSession.OpenSession())
            {
               
                using (ITransaction transaction = session.BeginTransaction())
                {                  
                    session.Save(model);
                    transaction.Commit();
                }
            }
        }

        public void Update(int id, Employees model)
        {
            using(ISession session = OpenNHibertnateSession.OpenSession())
            {
                var employee = session.Get<Employees>(id);
                employee.EmployeeId = model.EmployeeId;
                employee.EmployeeName = model.EmployeeName;
                employee.EmployeeSalary = model.EmployeeSalary;

                using (ITransaction transaction = session.BeginTransaction())
                {                   
                    session.Update(employee);
                    transaction.Commit();
                }
            }
        }

        public void Delete(int id)
        {
            using(ISession session = OpenNHibertnateSession.OpenSession())
            {
                var employee = session.Get<Employees>(id);

                using (ITransaction transaction = session.BeginTransaction())
                {                   
                    session.Delete(employee);
                    transaction.Commit();
                }                
            }
        }
    }
}
