using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class ColaboradorController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();
        //
        // GET: /Colaborador/
        public ActionResult Index()
        {
            var listado = proxy.ListarColaborador();
            return View(listado);
        }


        public ActionResult Crear()
        {
            var proxy = new TransaccionesClient();
            var listarCargo = proxy.ListaCargo();
            ViewBag.IDCARGO = new SelectList(listarCargo, "idCargo", "descripcion");
            return View();
        

        }

    [HttpPost]
        public ActionResult Crear(Colaborador cola,int idcargo)
        {
            var proxy = new TransaccionesClient();
            var cargo = proxy.obtenerCargo(idcargo);
            cola.Cargo = cargo;
            proxy.crearColaborador(cola);
            return RedirectToAction("Index");
            
        }

    }
}