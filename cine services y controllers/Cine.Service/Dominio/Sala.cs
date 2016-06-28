using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Sala
    {

        public int idSala { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public int capacidad { get; set; }

        //Relaciones
        public Local idLocal { get; set; }



    }
}