using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class PeliculaController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Pelicula/

        #region Listar
  public ActionResult Index()
        {
            var listado = proxy.ListarPelicula();
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
  public ActionResult Crear(Pelicula pelicula, int idgenero)
  {
      var proxy = new TransaccionesClient();
      var genero = proxy.obtenerGenero(idgenero);
      pelicula.Genero = genero;
      proxy.crearPelicula(pelicula);
      return RedirectToAction("Index");

  }
  #endregion


       #region -Actualizar-
  public ActionResult Actualizar(int? id)
  {
      Pelicula PE = new Pelicula();
      if (id.HasValue)
      {
          var proxy = new TransaccionesClient();
          var listarGenero = proxy.ListarGenero();
          ViewBag.idgenero = new SelectList(listarGenero, "idGenero", "nombre");
          var pe = proxy.obtenerPelicula(id.Value);
          return View(pe);
      }
      else

          return RedirectToAction("Index");

  }

  [HttpPost]
  public ActionResult Actualizar(Pelicula pelicula, int idgenero)
  {
      var proxy = new TransaccionesClient();
      var genero = proxy.obtenerGenero(idgenero);
      pelicula.Genero = genero;
      proxy.actualizarPelicula(pelicula);
      return RedirectToAction("Index");

  }

  #endregion
  
	}
}