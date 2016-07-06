using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWenCliente.CineWS;

namespace Cine.AppWenCliente.Controllers
{
    public class EstrenosController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Estrenos/
        public ActionResult Index()
        {
            var listado = proxy.ListarEstrenos();
            return View(listado);
        }
	}
}