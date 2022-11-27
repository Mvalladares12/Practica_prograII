using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas_MVC.WCF;

namespace Ventas_MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(RespuestaUsuario datos)
        {
            RespuestaUsuario datoswebservice;

            Service1Client wcf = new Service1Client();

            datoswebservice = wcf.InicioSesion(datos);

            if(datoswebservice.NombreUsuario != null)
            {
                Session["Usuario"] = datoswebservice.Usuario;
                Session["NombreUsuario"] = datoswebservice.NombreUsuario;

                return RedirectToAction("Index", "Producto");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}