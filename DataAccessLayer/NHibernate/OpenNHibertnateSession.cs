using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace DataAccessLayer.NHibernate
{
    public class OpenNHibertnateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
           
            var configurationPath = Path.Combine
                (@"E:\Company_Task\useNHibernate_Mvc\DataAccessLayer\NHibernate\NHibernate.Configuration.xml");
            configuration.Configure(configurationPath);

            var employeeConfiguartionFile = Path.Combine
                (@"E:\Company_Task\useNHibernate_Mvc\DataAccessLayer\NHibernate\Employee.Mapping.xml");
            configuration.AddFile(employeeConfiguartionFile);

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
