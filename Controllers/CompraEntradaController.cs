using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class CompraEntradaController : Controller
    {
        TransaccionesClient proxy = new TransaccionesClient();

        //
        // GET: /CompraEntrada/
        public ActionResult Index()
        {
            var listado = proxy.ListarCompraEntrada();
            return View(listado);
        }
        #region -Crear-
        public ActionResult Crear()
        {
            var proxy = new TransaccionesClient();
            var listarTipo = proxy.ListarTipoEntrada();
            ViewBag.idTipo = new SelectList(listarTipo, "idTipoEntrada", "nombre");

            var listarFuncion = proxy.ListarFuncion();
            ViewBag.idFuncion = new SelectList(listarFuncion, "idFuncion", "idFuncion");

            var listare = proxy.ListarEspectador();
            ViewBag.idEs = new SelectList(listare, "idEspectador", "apellidoPaterno");
           
            return View();

        }


        [HttpPost]
        public ActionResult Crear(CompraEntrada compra, int idTipo, int idfuncion, int idEs)
        //public ActionResult Crear(CompraEntrada compra,int idTipo,int idfuncion)
        {
            var proxy = new TransaccionesClient();

            var tipo = proxy.obtenerTipoEntrada(idTipo);
            var fun = proxy.obtenerFuncion(idfuncion);
            var ides = proxy.obtenerEspectador1(idEs);

            compra.tipoEntrada = tipo;
            compra.Funcion = fun;
            compra.Espectador = ides;

            proxy.crearCompraEntrada(compra);
            return RedirectToAction("Index");

        }
        #endregion
        
	}
}