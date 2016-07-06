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

        public ActionResult Actualizar(int? id)
        {
            
            if (id.HasValue)
            {
                var proxy = new TransaccionesClient();
                var com = proxy.obtenerCargo(id.Value);
                return View(com);
            }
            else

                return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult Actualizar(Cargo car)
        {
            var proxy = new TransaccionesClient();
            proxy.actualizarCargo(car);
            return RedirectToAction("Index");

        }

       
	}
}