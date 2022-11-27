using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica_prograII
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text + " " + txtApellido.Text;
            double Salario = double.Parse(txtSalario.Text);
            int Valor = int.Parse(ddlPuesto.SelectedValue.ToString());
            string puesto = ddlPuesto.Text;
            double Renta = 0.0;
            double SalarioNeto = 0;
            switch (Valor)
            {
                case 1:
                    Renta = Salario * 0.2;
                    break;
                case 2:
                    Renta = Salario * 0.1;
                    break;
                case 3:
                    Renta = Salario * 0.05;
                    break;
                case 4:
                    Renta = Salario * 0.01;
                    break;
            }
            SalarioNeto = Salario - Renta;
            lblNombre.Text = Nombre;
            lblPuesto.Text = puesto;
            lblSalarioBase.Text = Salario.ToString();
            lblDescuentoRenta.Text = Renta.ToString();
            lblSalarioNeto.Text = SalarioNeto.ToString();
        }
    }
}