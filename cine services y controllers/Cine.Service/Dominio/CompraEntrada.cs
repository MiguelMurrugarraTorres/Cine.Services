using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class CompraEntrada
    {

        public int idCompraEntrada { get; set; }
        public int cantidad { get; set; }

        //RELACIONES
        public TipoEntrada idTipoEntrada { get; set; }


    }
}