using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class CarteleraController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Cartelera/
        public ActionResult Index()
        {
            var listado = proxy.ListarCartelera();
            return View(listado);
        }


        public ActionResult Crear()
        {
            var proxy = new TransaccionesClient();
            var listarPelicula = proxy.ListarPelicula();
            ViewBag.Idpelicula = new SelectList(listarPelicula, "idPelicula", "titulo");
            return View();

        }


        [HttpPost]
        public ActionResult Crear(Cartelera carte, int idpelicula)
        {
            var proxy = new TransaccionesClient();
            var peli = proxy.obtenerPelicula(idpelicula);
            carte.pelicula = peli;
            proxy.crearCartelera(carte);
            return RedirectToAction("Index");

        }
	}
}