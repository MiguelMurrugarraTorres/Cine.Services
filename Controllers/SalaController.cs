using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{

   
    public class SalaController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Sala/
        public ActionResult Index()
        {
            var listado = proxy.ListarSala();
            return View(listado);
        }

        public ActionResult Crear()
        {
            var proxy = new TransaccionesClient();
            var listarlocales = proxy.ListarLocales();
            ViewBag.idloca = new SelectList(listarlocales, "idLocal", "nombre");
            return View();

        }
        [HttpPost]
        public ActionResult Crear(Sala sala, int idloca)
        {
            var proxy = new TransaccionesClient();
            var lo = proxy.obtenerLocal(idloca);
            sala.Local = lo;
            proxy.crearSala(sala);
            return RedirectToAction("Index");

        }
	}
}