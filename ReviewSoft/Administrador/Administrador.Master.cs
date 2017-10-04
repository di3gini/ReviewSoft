using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReviewSoft.Administrador
{
    public partial class Administrador : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                if (Session["Rol"].ToString() != "Administrador")
                {
                    Response.Redirect("/Inicio.aspx");
                }
            }
            else
            {
                Response.Redirect("/Inicio.aspx");
            }
        }
    }
}