using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ventas_asp.Mantenimiento
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardarProd_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombreProd.Text;
            double precio = double.Parse(TxtPrecioProd.Text);
            int id_categoria = int.Parse(DdlCategoria.SelectedValue.ToString());
            string usuario_ins = Session["Usuario"].ToString();

            DataTable datos = Conexion.Insert_Producto(nombre, precio, id_categoria, usuario_ins);

            LblMensaje.Text = datos.Rows[0]["Mensaje"].ToString();
        }

        protected void GvProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtIDCate.Text = GvProducto.SelectedRow.Cells[1].Text;
            TxtNombreProd.Text = GvProducto.SelectedRow.Cells[2].Text;
            TxtPrecioProd.Text = GvProducto.SelectedRow.Cells[4].Text;
        }

        protected void BtnModificarProd_Click(object sender, EventArgs e)
        {

        }
    }
}