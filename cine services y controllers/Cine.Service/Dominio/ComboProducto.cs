using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class ComboProducto
    {
        public Combo idCombo { get; set; }///relacion
        public Producto idProducto { get; set; }///relacion

    }
}