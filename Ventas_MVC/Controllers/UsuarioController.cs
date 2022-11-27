using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas_MVC.WCF;

namespace Ventas_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        VentasBDDataContext user = new VentasBDDataContext();
        // GET: Usuario
        public ActionResult Index()
        {
            List < Usuarios > Usuario=(from u in user.Usuarios
                                       select u).ToList();
            return View(Usuario);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            Usuarios usuario = (from u in user.Usuarios
                                where u.id_usuario == id
                                select u).Single();
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            var listauser = (from u in user.Usuarios
                             select u).ToList();
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, GuardaUser datos)
        {
            try
            {
                // TODO: Add insert logic here
                GuardaUser datosweb;
                Service1Client WCF = new Service1Client();
                datosweb = WCF.creausuario(datos);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            V_usuarios usu = (from u in user.V_usuarios
                            where u.id_usuario == id
                            select u).Single();
            return View(usu);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, EditarUser datos)
        {
            try
            {
                // TODO: Add update logic here
                EditarUser datosweb;
                Service1Client wcf = new Service1Client();
                datos.Id_usuario = id;
                datosweb = wcf.editar(datos);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            Usuarios usu = (from u in user.Usuarios
                            where u.id_usuario == id
                            select u).Single();
            return View(usu);
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection, EliminarUser datos)
        {
            try
            {
                // TODO: Add delete logic here
                EliminarUser datosweb;
                Service1Client wcf = new Service1Client();
                datos.Id_usuario = id;
                datosweb = wcf.eliminar(datos);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
