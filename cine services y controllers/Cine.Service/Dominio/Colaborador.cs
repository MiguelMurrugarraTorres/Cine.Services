using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;
using Cine.Service.Dominio;

namespace Cine.Service.Dominio
{

  
    public class Colaborador
    {
        public int idColaborador { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string password { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public Cargo Cargo { get; set; } ///relacion


    }
}