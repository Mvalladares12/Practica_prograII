using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_Encuesta
{
    public partial class Index : System.Web.UI.Page
    {
        static int Informatico;
        static int Contador;
        static int Servicio;
        static int Abogado;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int valor_profesion = Convert.ToInt32(ddlProfesion.SelectedValue.ToString());
            int edad = int.Parse(txtEdad.Text);

            switch(valor_profesion)
            {
                case 1: //informatico
                    if (chkTrabaja.Checked)
                    {
                        Informatico++;
                    }
                    break;
                case 2: //contador
                    if(!chkTrabaja.Checked)
                    {
                        Contador++;
                    }
                    break;
                case 3: //servicio
                    if (!chkTrabaja.Checked && edad>=25 && edad <=35)
                    {
                        Servicio++;
                    }
                    break;
                case 4: //abogado
                    if (edad > 35)
                    {
                        Abogado++;
                    }
                    break;
            }
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            lblInformaticos.Text = Informatico.ToString();
            lblContadores.Text = Contador.ToString();
            lblAbogados.Text = Abogado.ToString();
            lblServicio.Text = Servicio.ToString();
        }
    }
}