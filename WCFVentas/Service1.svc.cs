using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFVentas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        DBVentasDataContext db = new DBVentasDataContext();

        public RespuestaUsuario InicioSesion(RespuestaUsuario datos)
        {
            var usuario = (from u in db.Usuarios
                           where u.Usuario == datos.Usuario
                           && u.Contraseña == datos.Contrasena
                           select u).ToList();

            if (usuario.Count > 0)
            {
                datos.NombreUsuario = usuario[0].Nombre_usuario;
            }
            return datos;
        }

        public Ventas GuardarVentas(Ventas datos)
        {
            datos.Fecha = DateTime.Now;
            datos.FechaI = DateTime.Now;
            datos.Vendedor = "mvalladares";
            db.SP_InsertarVenta(datos.Producto,datos.Fecha,datos.FechaI, datos.Cliente, datos.cantidad,datos.Vendedor);
            db.SubmitChanges();
            return datos;
        }
        
        public Detalles VerVenta(Detalles ver)
        {
            List<V_ventas> List = (from v in db.V_ventas
                                   where v.id_venta==ver.Id_venta
                                   select v).ToList();
            if (List.Count > 0)
            {
                ver.Producto = List[0].Nombre_producto;
                ver.Vendedor = List[0].usuario_inserta;
                ver.Fecha = List[0].Fecha_venta;
            }
            return ver;
        }

        public GuardaUser creausuario(GuardaUser datos)
        {
            datos.Fecha_Inserta = DateTime.Now;
            datos.Usuario_Inserta = "mvalladares";
            db.SP_InsertarUsuario(datos.Usuario,datos.Contraseña,datos.Usuario_Inserta,datos.Fecha_Inserta,datos.Nombre_Usuario);
            db.SubmitChanges();
            return datos;
        }

        public EditarUser editar(EditarUser datos)
        {
            datos.Usuario_actualiza = "mvalladares";
            db.SP_EditarUsuario(datos.Id_usuario,datos.Usuario,datos.Contraseña,datos.Usuario_inserta,datos.Nombre_usuario,datos.Usuario_actualiza);
            db.SubmitChanges();
            return datos;
        }

        public EliminarUser eliminar(EliminarUser datos)
        {
            db.SP_EliminarUser(datos.Id_usuario);
            db.SubmitChanges();
            return datos;
        }
    }
}
