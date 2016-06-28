using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Estrenos
    {
        public int idPelicula { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public string duracion { get; set; }
        public string director { get; set; }
        public string actores { get; set; }
        public string sitioWeb { get; set; }
        public DateTime fechaEstreno { get; set; }
        public string estado { get; set; }
        //RELACIONES
        public Genero Genero { get; set; }
        public string imagen { get; set; }

    }
}