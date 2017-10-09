using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReviewSoft;

namespace ReviewSoft.Administrador.Editar
{
    public partial class Aplicaciones : System.Web.UI.Page
    {
        Catalogos_Datos cd = new Catalogos_Datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdVerDatos.DataSource = cd.TodoSoftware();
            grdVerDatos.DataBind();
        }

        protected void grdVerDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdVerDatos_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}