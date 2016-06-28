using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class EstrenosController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();

        //
        // GET: /Estrenos/
        #region -LISTAR-
public ActionResult Index()
        {
            var listado = proxy.ListarEstrenos();
            return View(listado);
        }
        #endregion
        

        #region -Crear-
        public ActionResult Crear()
        {
            var proxy = new TransaccionesClient();
            var listarGenero = proxy.ListarGenero();
            ViewBag.idgenero = new SelectList(listarGenero, "idGenero", "nombre");
            return View();

        }


        [HttpPost]
        public ActionResult Crear(Estrenos pelicula, int idgenero)
        {
            var proxy = new TransaccionesClient();
            var genero = proxy.obtenerGenero(idgenero);
            pelicula.Genero = genero;
            proxy.crearEstrenos(pelicula);
            return RedirectToAction("Index");

        }
        #endregion

        #region -Actualizar-
        public ActionResult Actualizar(int? id)
        {
            //Estrenos ES = new Estrenos();
            if (id.HasValue)
            {
                var proxy = new TransaccionesClient();
                var listarGenero = proxy.ListarGenero();
                ViewBag.idgenero = new SelectList(listarGenero, "idGenero", "nombre");
                var pe = proxy.obtenerEstrenos(id.Value);
                return View(pe);
            }
            else

                return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Actualizar(Estrenos estre, int idgenero)
        {
            var proxy = new TransaccionesClient();
            var genero = proxy.obtenerGenero(idgenero);
            estre.Genero = genero;
            proxy.actualizarEstrenos(estre);
            return RedirectToAction("Index");
        }

        #endregion
        
        
        #region -Eliminar-
        public ActionResult Eliminar(int? id)
        {
            if (id.HasValue)
            {
                var proxy = new TransaccionesClient();
                var pe = proxy.obtenerEstrenos(id.Value);
                return View(pe);
            }
            else

                return RedirectToAction("Index");
        }

             [HttpPost]
        public ActionResult Eliminar(String id)
        {
            var proxy = new TransaccionesClient();
            proxy.EliminarEstreno(id);
            return RedirectToAction("Index");
        }

        #endregion

        

    }
}