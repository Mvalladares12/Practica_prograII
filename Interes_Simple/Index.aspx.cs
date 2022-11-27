using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interes_Simple
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double Capital = double.Parse(txtCapital.Text);
            double Interes = double.Parse(txtInteres.Text);
            int años = int.Parse(txtAños.Text);
            double InteresGanado = 0;
            double Monto = 0;

            InteresGanado = (Capital * (Interes/100))*años;
            Monto = Capital + InteresGanado;

            txtGanancia.Text = InteresGanado.ToString();
            txtMonto.Text = Monto.ToString();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCapital.Text = string.Empty;
            txtInteres.Text = string.Empty;
            txtAños.Text = string.Empty;
            txtGanancia.Text = string.Empty;
            txtMonto.Text = string.Empty;
        }
    }
}