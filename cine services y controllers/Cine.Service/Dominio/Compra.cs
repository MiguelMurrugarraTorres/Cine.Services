using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Compra
    {

        public int idCompra { get; set; }
        public DateTime fecha { get; set; }
        public decimal montoTotal { get; set; }
       

        //RELACIONES
        public CompraEntrada Entradas { get; set; } 
        public TipoCompraProducto   CompraPro { get; set; }
        public Funcion Funcion { get; set; }
        public Espectador Espectador { get; set; }
    }
}