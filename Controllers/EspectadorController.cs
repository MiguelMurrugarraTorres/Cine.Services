using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class EspectadorController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Espectador/
        public ActionResult Index()
        {
            var listado = proxy.ListarEspectador();
            return View(listado);
        }

        public ActionResult Crear()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Crear(Espectador esp)
        {
            var proxy = new TransaccionesClient();
            proxy.crearEspectador(esp);
            return RedirectToAction("Index");

        }


        public ActionResult Actualizar(int? id)
        {
           
            if (id.HasValue)
            {
                var proxy = new TransaccionesClient();
                var espe = proxy.obtenerEspectador1(id.Value);
                return View(espe);
            }
            else

                return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult Actualizar(Espectador ES)
        {
            var proxy = new TransaccionesClient();
            proxy.actualizarEspectador(ES);
            return RedirectToAction("Index");

        }
	}
}