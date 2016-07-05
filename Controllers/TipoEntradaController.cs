using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;
namespace Cine.AppWeb.Controllers
{
    public class TipoEntradaController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /TipoEntrada/

        #region  -LISTAR-

 public ActionResult Index()
        {
            var listado = proxy.ListarTipoEntrada();
            return View(listado);
        }
        #endregion

        #region -CREAR-
 public ActionResult Crear()
 {

     return View();

 }


 [HttpPost]
 public ActionResult Crear(TipoEntrada tipo)
 {
     var proxy = new TransaccionesClient();
     proxy.crearTipoEntrada(tipo);
     return RedirectToAction("Index");

 }
        #endregion


        #region-MODIFICAR-
 public ActionResult Actualizar(int? id)
 {
     if (id.HasValue)
     {
         var proxy = new TransaccionesClient();
         var tipo = proxy.obtenerTipoEntrada(id.Value);
         return View(tipo);
     }
     else

         return RedirectToAction("Index");

 }
 [HttpPost]
 public ActionResult Actualizar(TipoEntrada tipo)
 {
     var proxy = new TransaccionesClient();
     proxy.actualizarTipoEntrada(tipo);
     return RedirectToAction("Index");

 }
        #endregion
       
        

       

        #region -Eliminar-
        public ActionResult Eliminar(int? id)
        {
            if (id.HasValue)
            {
                var proxy = new TransaccionesClient();
                var pe = proxy.obtenerTipoEntrada(id.Value);
                return View(pe);
            }
            else

                return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Eliminar(String id)
        {
            var proxy = new TransaccionesClient();
            proxy.EliminarTipoEntrada(id);
            return RedirectToAction("Index");
        }

        #endregion

	}
}