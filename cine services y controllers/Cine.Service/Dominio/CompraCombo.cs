using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class CompraCombo
    {
        public int idCompraCombo { get; set; }
        public int cantidad { get; set; }

        //RELACIONES

        public TipoCompraProducto  idTipoCompra { get; set; }
        public Combo idCombo { get; set; }
    
    }
}