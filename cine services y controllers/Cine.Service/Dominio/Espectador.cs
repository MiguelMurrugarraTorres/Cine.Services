using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Service.Dominio
{
    public class Espectador
    {

        public int idEspectador { get; set; }
        public string contraseña { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        
        public TipoEspectador idEpectador { get ; set;}


    }
}