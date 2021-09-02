using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cache;
using System;
using System.Reflection;

namespace PowerPlant.RelationalRepository
{
    public class FluentNHibernateSessionFactoryBuilder
    {
        public ISessionFactory GetSessionFactory(string connectionString, Assembly assembly)
        {
            try
            {
                return Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
                    .Cache(c =>
                        c.UseQueryCache()
                            .ProviderClass<HashtableCacheProvider>())
                            .Mappings(m => m.FluentMappings.AddFromAssembly(assembly))
                            .BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
