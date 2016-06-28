using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class TipoEntrada
    {

        public int idTipoEntrada { get; set; }
        public string nombre { get; set; }
        public decimal precioNormal { get; set; }
        public decimal precioFeriado { get; set; }
        public decimal oferta { get; set; }
        public DateTime fecha { get; set; }
    
    }
}