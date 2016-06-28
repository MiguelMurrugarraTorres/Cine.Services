using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.AppWeb.CineWS;

namespace Cine.AppWeb.Controllers
{
    public class LoginController : Controller
    {
        TransaccionesClient proxy =new  TransaccionesClient();
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(ColaUser col)
        {

            var listado = proxy.Login(col);
            return View(listado);


        }


	}
}