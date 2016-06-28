using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class GeneroController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();

        //
        // GET: /Genero/
        public ActionResult Index()
        {
            var listado = proxy.ListarGenero();
            return View(listado);
        }

        public ActionResult Crear()
        {

            return View();

        }


        [HttpPost]
        public ActionResult Crear(Genero genero)
        {
            var proxy = new TransaccionesClient();
            proxy.crearGenero(genero);
            return RedirectToAction("Index");

        }
	}
}