using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Combo
    {

        public int idCombo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precioVenta { get; set; }
        public string imagen { get; set; }

    }
}