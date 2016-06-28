using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class ComboController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        
        //
        // GET: /Combo/
        public ActionResult Index()
        {
            var listado = proxy.ListarCombo();
            return View(listado);
        }

        public ActionResult Crear()
        {

            return View();

        }


        [HttpPost]
        public ActionResult Crear(Combo cola)
        {
            var proxy = new TransaccionesClient();
            proxy.crearCombo(cola);
            return RedirectToAction("Index");

        }

        public ActionResult Actualizar(int? id)
        {
            Combo COM = new Combo();
            if (id.HasValue)
            {
                var proxy = new TransaccionesClient();
                var com = proxy.obtenerCombo(id.Value);
                return View(com);
            }
            else

                return RedirectToAction("Index");

        }
          [HttpPost]
        public ActionResult Actualizar(Combo cola)
        {
            var proxy = new TransaccionesClient();
            proxy.actualizarCombo(cola);
            return RedirectToAction("Index");

        }
	}
}