using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using PTS.Dao;

namespace PTS.Service.Helper
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory GetSessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            try
            {
                _sessionFactory = Fluently.Configure()
                               .Database(MsSqlConfiguration
                               .MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey("DatabaseConnection")).ShowSql())
                               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TestDao>())
                    //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                               .BuildSessionFactory();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }



        public static ISession OpenSession()
        {
            return GetSessionFactory.OpenSession();
        }
    }
}
