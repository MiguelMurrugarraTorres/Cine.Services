using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class LocalController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Local/
        public ActionResult Index()
        {
            var listado = proxy.ListarLocales();
            return View(listado);
        }

        public ActionResult Crear()
        {
            var proxy = new TransaccionesClient();
            var listarColabor = proxy.ListarColaborador();
            ViewBag.idCola = new SelectList(listarColabor, "idColaborador", "apellidoPaterno");
            return View();

        }
        [HttpPost]
        public ActionResult Crear(Local local, int idcola)
        {
            var proxy = new TransaccionesClient();
            var colabo = proxy.obtenerColaborador(idcola);
            local.Colaborador = colabo;
            proxy.CrearLocal(local);
            return RedirectToAction("Index");

        }
	}
}