using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using ReviewSoft;

namespace ReviewSoft
{
    public partial class Perfil : System.Web.UI.Page
    {
        LogicaUsuarios lu = new LogicaUsuarios();
        private void alCargar()
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }
            else
            {
                ddlProfesion.DataValueField = "ID";
                ddlProfesion.DataTextField = "Nombre";
                ddlProfesion.DataSource = lu.Profesiones();
                ddlProfesion.DataBind();

                DataRow dt;
                dt = lu.perfilUsuario(Session["Usuario"].ToString()).Rows[0];


                txtNombre.Text = dt[0].ToString();
                txtApellido.Text = dt[1].ToString();
                txtNacimiento.Text = dt[2].ToString();
                txtCorreo.Text = dt[3].ToString();
                ddlProfesion.SelectedValue = dt[5].ToString();

            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            alCargar();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}