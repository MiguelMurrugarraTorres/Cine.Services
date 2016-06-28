using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Funcion
    {


        public int idFuncion { get; set; }
        public DateTime horario { get; set; }

        //RELACIONES
        public Pelicula idPelicula { get; set; }
        public Sala idSala { get; set; }
    
    
    }
}