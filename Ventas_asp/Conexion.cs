using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient; 

namespace Ventas_asp
{
    public static class Conexion
    {
        static string Cadena = "Data source=DESKTOP-FUKI3JG; Initial Catalog=Ventas_progra2;Integrated Security=true";
        static DataSet datos = new DataSet();

        public static DataTable Login(string usuario, string contraseña /*,string usuario_ins*/)
        {
            datos = new DataSet();
            using (SqlDataAdapter da=new SqlDataAdapter("SP_Login", Cadena))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                da.SelectCommand.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contraseña;
                //da.SelectCommand.Parameters.Add("@asdfasd", SqlDbType.VarChar).Value = usuario_ins;

                da.Fill(datos);
            }
            return datos.Tables[0];
        }

        public static DataTable Insert_Categoria(string nombre_cate, string descripcion, string usuario)
        {
            datos = new DataSet();
            using (SqlDataAdapter data = new SqlDataAdapter("Insert_Categorias", Cadena))
            {
                data.SelectCommand.CommandType = CommandType.StoredProcedure;

                data.SelectCommand.Parameters.Add("@nombre_cate", SqlDbType.VarChar).Value = nombre_cate;
                data.SelectCommand.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
                data.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;

                data.Fill(datos);
            }
            return datos.Tables[0];
        }

        public static DataTable Insert_Producto(string nombre_prod, double precio, int id_categoria,string usuario_ins)
        {
            datos = new DataSet();
            using (SqlDataAdapter data = new SqlDataAdapter("SP_GuardaProducto", Cadena))
            {
                data.SelectCommand.CommandType = CommandType.StoredProcedure;

                data.SelectCommand.Parameters.Add("@Nombre_prod", SqlDbType.VarChar).Value = nombre_prod;
                data.SelectCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                data.SelectCommand.Parameters.Add("@id_categoria", SqlDbType.Int).Value = id_categoria;
                data.SelectCommand.Parameters.Add("@usuario_ins", SqlDbType.VarChar).Value = usuario_ins;

                data.Fill(datos);
            }
            return datos.Tables[0];
        }
        public static void EliminarProducto(string id_producto)
        {
            datos = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter("SP_EliminarProducto", Cadena))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int).Value = id_producto;
            }
        }

        /*public static void EditarProducto(string Nombreprod, double precio, string usuarioins, string usuarioact)
        {
            datos = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter("SP_ActualizaProducto", Cadena))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("@NombreProd", SqlDbType.VarChar).Value = Nombreprod;
                da.SelectCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                da.SelectCommand.Parameters.Add("@UsuarioIns", SqlDbType.Int).Value = usuarioins;
                da.SelectCommand.Parameters.Add("@UsuarioAct", SqlDbType.Int).Value = usuarioact;
            }
        }*/
        public static DataTable ActualizaProducto(string Nombre, double precio, int id, int id_Categoria)
        {
            datos = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter("SP_ActualizaProducto", Cadena))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("@NombreProd", SqlDbType.VarChar).Value = Nombre;
                da.SelectCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                da.SelectCommand.Parameters.Add("@idproducto", SqlDbType.Int).Value = id;
                da.SelectCommand.Parameters.Add("@idCategoria", SqlDbType.Int).Value = id_Categoria;

                da.Fill(datos);
            }
            return datos.Tables[0];
        }

        public static DataTable ActualizaUsuario(int idusuario,string NombreUsuario, string Usuario, string Contra)
        {
            datos = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter("SP_ActualizaUsuario", Cadena))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario;
                da.SelectCommand.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = NombreUsuario;
                da.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
                da.SelectCommand.Parameters.Add("@Contra", SqlDbType.VarChar).Value = Contra;

                da.Fill(datos);
            }
            return datos.Tables[0];
        }
    }
}