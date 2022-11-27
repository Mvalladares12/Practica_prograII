using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas_MVC.WCF;

namespace Ventas_MVC.Controllers
{
    public class VentaController : Controller
    {
        VentasBDDataContext Prod = new VentasBDDataContext();
        // GET: Venta
        public ActionResult Index()
        {
            List<V_venta> List = (from c in Prod.V_venta
                                     select c).ToList();
            return View(List);
        }

        // GET: Venta/Details/5
        public ActionResult Details(int id, Detalles ver)
        {
            Detalles datosweb;
            Service1Client wcf = new Service1Client();
            ver.Id_venta = id;
            datosweb = wcf.VerVenta(ver);
            return View(datosweb);
        }

        // GET: Venta/Create
        public ActionResult Create()
        {
            var listaprod = (from p in Prod.Productos
                             select p).ToList();

            ViewBag.listaprod = listaprod;

            return View();
        }

        // POST: Venta/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, WCF.Ventas datos)
        {
            try
            {
                // TODO: Add insert logic here
                WCF.Ventas datosweb;
                Service1Client WCF = new Service1Client();
                datosweb = WCF.GuardarVentas(datos);

                return RedirectToAction("Index","Venta");
            }
            catch
            {
                return View();
            }
        }

        // GET: Venta/Edit/5
        public ActionResult Edit(int id)
        {
            Ventas objVenta = (from v in Prod.Ventas
                               where v.id_venta == id
                               select v).Single();

            var listaprod = (from p in Prod.Productos
                             select p).ToList();
            ViewBag.listaprod = listaprod;

            return View(objVenta);
        }

        // POST: Venta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, Ventas datos)
        {
            try
            {
                // TODO: Add update logic here
                string usuario = "mvalladares";

                Prod.SP_EditarVenta(datos.Cantidad, datos.id_producto,datos.Usuario_venta,usuario, id);
                Prod.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Venta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Venta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
