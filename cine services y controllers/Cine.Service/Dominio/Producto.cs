using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Producto
    {

        public int idProducto { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; } 
        
        //RELACIONES
        public TipoCompraProducto TipoCompra { get; set; }
    
    }
}