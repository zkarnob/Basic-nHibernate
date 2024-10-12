using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using StudentManagementSystem.DataAccess.Entities;


namespace StudentManagementSystem.DataAccess
{
    public class SessionFactory
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory CreateSessionFactory()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012
                        .ConnectionString(@"Server=ZAWAD_H_TOOL\SQLEXPRESS;Database=StudentDB;Integrated Security=True;TrustServerCertificate=True;"))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Student>())
                    .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
                    .BuildSessionFactory();
            }
            return _sessionFactory;
        }

        public static ISession OpenSession()
        {
            return CreateSessionFactory().OpenSession();
        }
    }
}
