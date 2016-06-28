using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Local
    {

        public int idLocal { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string provincia { get; set; }
        public int  capacidad { get; set; }
        public int telefono { get; set; }
        public string administrador { get; set; }

        //RELACIONES
        public Colaborador idColaborador { get; set; }


    }
}