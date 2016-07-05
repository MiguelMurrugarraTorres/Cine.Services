using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class FuncionController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Funcion/
        public ActionResult Index()
        {
            var listado = proxy.ListarFuncion();
            return View(listado);
        }
        #region -Crear-
        public ActionResult Crear()
        {
            var proxy = new TransaccionesClient();

            
            var listarPelicula = proxy.ListarPelicula();
            ViewBag.idpelicula = new SelectList(listarPelicula, "idPelicula", "titulo");
            var listarSala = proxy.ListarSala();
            ViewBag.idsala = new SelectList(listarSala, "idSala", "descripcion");
            
            return View();

        }


        [HttpPost]
        public ActionResult Crear(Funcion funcion, int idpelicula, int idsala)
       // public ActionResult Crear(Funcion funcion,int idsala)
        {
            var proxy = new TransaccionesClient();
            var proxy2 = new TransaccionesClient();
            var peli = proxy2.obtenerPelicula(idpelicula);
            var sala = proxy.obtenerSala(idsala);

           funcion.pelicula = peli;
            funcion.sala = sala;
            proxy.crearFuncion(funcion);
            return RedirectToAction("Index");

        }
        #endregion

        #region -actualizar-
        public ActionResult Actualizar(int? id)
        {
            var proxy = new TransaccionesClient();

            if (id.HasValue)
            {
                var listarPelicula = proxy.ListarPelicula();
                ViewBag.idpelicula = new SelectList(listarPelicula, "idPelicula", "titulo");
                var listarSala = proxy.ListarSala();
                ViewBag.idsala = new SelectList(listarSala, "idSala", "descripcion");
                var fu=proxy.obtenerFuncion(id.Value);
                return View(fu);
            }
            else
                return RedirectToAction("Index");

        }


        [HttpPost]
        public ActionResult Actualizar(Funcion funcion, int idpelicula, int idsala)
        {
            var proxy = new TransaccionesClient();

            var peli = proxy.obtenerPelicula(idpelicula);
            var sala = proxy.obtenerSala(idsala);

            funcion.pelicula = peli;
            funcion.sala = sala;
            proxy.actualizarFuncion(funcion);
            return RedirectToAction("Index");

        }
        #endregion
	}
}