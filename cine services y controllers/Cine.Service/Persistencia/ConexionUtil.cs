using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "server=.;database=BDCinepolis1;integrated security=yes";
        }


    }
}