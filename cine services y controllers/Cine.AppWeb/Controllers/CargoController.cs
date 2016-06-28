using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class CargoController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Cargo/
        public ActionResult Index()
        {
            var listado = proxy.ListaCargo();
            return View(listado);
        }

        public ActionResult Crear()
        {

            return View();

        }


        [HttpPost]
        public ActionResult Crear(Cargo cargo)
        {
            var proxy = new TransaccionesClient();
            proxy.crearcargo(cargo);
            return RedirectToAction("Index");

        }
	}
}