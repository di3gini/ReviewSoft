﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReviewSoft.Administrador.Editar
{
    public partial class Metricas : System.Web.UI.Page
    {
        Catalogos_Datos cd = new Catalogos_Datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdVerDatos.DataSource = cd.TodaMetrica();
            grdVerDatos.DataBind();
        }
    }
}