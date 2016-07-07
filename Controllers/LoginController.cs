using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class LoginController : Controller
    {
        TransaccionesClient proxy =new  TransaccionesClient();
        //
        // GET: /Login/
      public ActionResult Iniciar()
        {

            return View();
        }

         [HttpPost]
        public ActionResult Iniciar(Colaborador colabo)
        {
            TransaccionesClient proxy = new TransaccionesClient();

            bool estado = proxy.IniciarSesionColaborador(colabo);
            Colaborador colaborador = new Colaborador();
            int idco = colaborador.idColaborador;
            //colaborador = proxy.obtenerColaborador(idco);
            //int pos = colaborador.idColaborador;
            string men="";
            string controlador = "";

            if (estado == true)
            {
                men = "Index";
                controlador = "ComprasEntrada.aspx";
                
            }
            else
            {
                
                men = "Iniciar";
                controlador = "Login";
                
            }

            return RedirectToAction(men, controlador, new { mensaje = idco });
        }
    }
}
