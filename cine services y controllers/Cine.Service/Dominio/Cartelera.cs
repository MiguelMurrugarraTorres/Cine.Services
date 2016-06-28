using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Cartelera
    {

        public int idCartelera { get; set; }
        public DateTime fechainicio { get; set; }
        public DateTime fechafin { get; set; }
        //RELACIONES
        public Pelicula pelicula{ get; set; }

    }
}