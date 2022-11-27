using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ventas_asp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contra = txtcontra.Text;

            DataTable datos = Conexion.Login(usuario, contra);

            int id_usu = int.Parse(datos.Rows[0][0].ToString());

            if (id_usu > 0)
            {
                //lblmensaje.Text = "Usuario encontrado " + datos.Rows[0]["Nombre_usuario"].ToString();
                Session["usuario_inserta"] = datos.Rows[0]["usuario_inserta"].ToString();
                Session["Nombre_usuario"] = datos.Rows[0]["Nombre_usuario"].ToString();
                Session["Usuario"] = datos.Rows[0]["Usuario"].ToString();

                Response.Redirect("Mantenimiento/Categorias.aspx");
                
            }
            else
            {
                lblmensaje.Text = datos.Rows[0]["Mensaje"].ToString();
            }
        }
    }
}