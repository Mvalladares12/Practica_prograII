using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ventas_MVC.Controllers
{
    public class CategoriaController : Controller
    {

        VentasBDDataContext ventas = new VentasBDDataContext();

        // GET: Categoria
        public ActionResult Index()
        {
            List<Categorias> Lista = (from c in ventas.Categorias
                                      select c).ToList();
            return View(Lista);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            Categorias objCategoria = (from ca in ventas.Categorias
                                       where ca.id_categoria == id
                                       select ca).Single();

            return View(objCategoria);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Categorias datos)
        {
            try
            {
                datos.fecha_inserta = DateTime.Now;
                datos.usuario_inserta = "Mario Valladares";

                ventas.Categorias.InsertOnSubmit(datos);

                ventas.SubmitChanges();

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            Categorias objCategoria = (from ca in ventas.Categorias
                                       where ca.id_categoria == id
                                       select ca).Single();

            return View(objCategoria);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, Categorias datos)
        {
            try
            {
                // TODO: Add update logic here
                string usuario = "mvalladares";
                ventas.SP_EditarCategoria(datos.Nombre_categoria, datos.Descripcion_categoria, usuario,id);

                ventas.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            Categorias objCategoria = (from ca in ventas.Categorias
                                       where ca.id_categoria == id
                                       select ca).Single();

            return View(objCategoria);
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Categorias objCategoria = (from ca in ventas.Categorias
                                           where ca.id_categoria == id
                                           select ca).Single();

                ventas.Categorias.DeleteOnSubmit(objCategoria);

                ventas.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
