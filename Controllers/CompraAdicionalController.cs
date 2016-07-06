using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;
namespace Cine.AppWeb.Controllers
{
    public class CompraAdicionalController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /CompraAdicional/
        public ActionResult Index()
        {
            var listado = proxy.ListarCompraAdicional();
            return View(listado);
        }
	}
}