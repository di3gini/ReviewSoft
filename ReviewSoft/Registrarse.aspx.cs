using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReviewSoft;

namespace ReviewSoft
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        LogicaUsuarios lu = new LogicaUsuarios();
        private void alCargar()
        {
            if (Session["Usuario"] == null)
            {
                ddlProfesion.DataValueField = "ID";
                ddlProfesion.DataTextField = "Nombre";
                ddlProfesion.DataSource = lu.Profesiones();
                ddlProfesion.DataBind();
            }
            else
            {
                Response.Redirect("~/Inicio.aspx");
            }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            alCargar();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == txtContraseña2.Text)
            {
                lu.insertarUsuario(txtNombre.Text, txtApellido.Text, txtNacimiento.Text, txtCorreo.Text, txtContraseña1.Text, Convert.ToInt32(ddlProfesion.SelectedValue));
            }
            
        }
    }
}