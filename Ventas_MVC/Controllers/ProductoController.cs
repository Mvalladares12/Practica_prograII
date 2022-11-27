using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ventas_MVC.Controllers
{
    public class ProductoController : Controller
    {
        VentasBDDataContext dbventas = new VentasBDDataContext();
        // GET: Producto
        public ActionResult Index()
        {
            List<V_producto> List = (from c in dbventas.V_producto
                                     select c).ToList();

            return View(List);
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            Productos objProducto = (from obj in dbventas.Productos
                                     where obj.id_producto == id
                                     select obj).Single();

            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {

            var listacate = (from c in dbventas.Categorias
                             select c).ToList();

            ViewBag.listacate = listacate;

            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Productos datos)
        {
            try
            {
                // TODO: Add insert logic here
                datos.usuario_inserta = "mvalladares";
                datos.fecha_inserta = DateTime.Now;

                dbventas.Productos.InsertOnSubmit(datos);

                dbventas.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            Productos objProducto = (from obj in dbventas.Productos
                                     where obj.id_producto == id
                                     select obj).Single();
            var listacate = (from c in dbventas.Categorias
                             select c).ToList();

            ViewBag.listacate = listacate;
            return View(objProducto);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, Productos datos)
        {
            try
            {
                // TODO: Add update logic here
                string usuario = "mvalladares";

                dbventas.SP_EditarProducto(datos.Nombre_producto, datos.id_categoria, datos.precio, usuario, id);

                dbventas.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            Productos objProducto = (from obj in dbventas.Productos
                                     where obj.id_producto == id
                                     select obj).Single();
            return View(objProducto);
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Productos objProducto = (from obj in dbventas.Productos
                                         where obj.id_producto == id
                                         select obj).Single();

                dbventas.Productos.DeleteOnSubmit(objProducto);

                dbventas.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
