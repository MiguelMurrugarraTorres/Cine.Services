
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Persistencia
{
    public class NHibernateHelper
    {
        private static ISessionFactory _cine;

        public static ISessionFactory CinePolis
        {
            get
            {
                if (_cine == null)
                {
                    var conf = new Configuration();
                    conf.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
                    conf.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver");
                    conf.SetProperty("connection.connection_string", ConexionUtil.ObtenerCadena());
                    conf.SetProperty("adonet.batch_size", "10");
                    conf.SetProperty("show_sql", "true");
                    conf.SetProperty("dialect", "NHibernate.Dialect.MsSql2000Dialect");
                    conf.SetProperty("command_timeout", "60");
                    conf.SetProperty("query.substitutions", "true 1, false 0, yes 'Y', no 'N'");
                    conf.AddAssembly(typeof(NHibernateHelper).Assembly);
                    _cine = conf.BuildSessionFactory();
                }
                return _cine;
            }
        }

        public static ISession ObtenerSesion()
        {
            return CinePolis.OpenSession();
        }
        public static void CerrarCine()
        {
            _cine = null;
        }
    }
}