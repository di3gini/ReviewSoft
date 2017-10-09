using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReviewSoft;

namespace ReviewSoft.Administrador.Editar
{
    public partial class Profesiones : System.Web.UI.Page
    {
        Catalogos_Datos cd = new Catalogos_Datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdVerDatos.DataSource = cd.TodaProfesion();
            grdVerDatos.DataBind();
        }
    }
}