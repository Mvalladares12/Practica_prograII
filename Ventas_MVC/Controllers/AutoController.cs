using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas_MVC.Models;

namespace Ventas_MVC.Controllers
{
    public class AutoController : Controller
    {
        // GET: Auto
        public ActionResult Index()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult Datos(Autos datos_auto)
        {
            ViewBag.anio = datos_auto.anio;
            ViewBag.marca = datos_auto.Marca;
            ViewBag.modelo = datos_auto.Modelo;
            ViewBag.fecha = datos_auto.FechaAuto;

            return View("Informacion");
        }*/

        [HttpPost]
        public ActionResult datos_modelo(Autos datos_modelo)
        {
            return View(datos_modelo);
        }
    }
}