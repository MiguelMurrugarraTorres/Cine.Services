using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWenCliente.CineWS;

namespace Cine.AppWenCliente.Controllers
{
    public class CarteleraController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Catelera/
        public ActionResult Index()
        {
            var list = proxy.ListarCartelera();
            return View(list);
        }
	}
}