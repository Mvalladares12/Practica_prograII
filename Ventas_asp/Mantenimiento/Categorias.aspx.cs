using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ventas_asp.Mantenimiento
{
    public partial class Categorias : System.Web.UI.Page
    {
         protected void Page_Load(object sender, EventArgs e)
         {
             lblUsuario.Text = Session["Nombre_usuario"].ToString();
             LblUsuario_ins.Text = Session["usuario_inserta"].ToString();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre= txtNombre.Text;
            string descripcion= txtDescripcion.Text;
            string usuario = LblUsuario_ins.Text;

            DataTable datos = Conexion.Insert_Categoria(nombre, descripcion, usuario);

            LblUsuario_ins.Text = Session["usuario_inserta"].ToString();

            lblMensaje.Text = datos.Rows[0]["Mensaje"].ToString();

        }

        protected void BtnProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("Productos.aspx");
        }
    }
}   