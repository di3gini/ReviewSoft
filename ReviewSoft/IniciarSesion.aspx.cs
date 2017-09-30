using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReviewSoft;

namespace ReviewSoft
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        LogicaUsuarios login = new LogicaUsuarios();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Response.Redirect("/Inicio.aspx");
            }
            if (!IsPostBack)
            {
                if (Request.Cookies["usuario"] != null)
                    txtUsuario.Text = Request.Cookies["usuario"].Value;
                if (Request.Cookies["pass"] != null)
                    txtContraseña.Attributes.Add("value", Request.Cookies["pass"].Value);
                if (Request.Cookies["usuario"] != null && Request.Cookies["pass"] != null)
                    chkRecordar.Checked = true;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (login.IniciarSesion(txtUsuario.Text, txtContraseña.Text) == "correcto")
            {
                if (chkRecordar.Checked == true)
                {
                    Response.Cookies["usuario"].Value = txtUsuario.Text;
                    Response.Cookies["pass"].Value = txtContraseña.Text;
                    Response.Cookies["usuario"].Expires = DateTime.Now.AddDays(15);
                    Response.Cookies["pass"].Expires = DateTime.Now.AddDays(15);
                }
                else
                {
                    Response.Cookies["usuario"].Expires = DateTime.Now.AddDays(-1d);
                    Response.Cookies["pass"].Expires = DateTime.Now.AddDays(-1d);
                }
                Response.Redirect("/Inicio.aspx");
            }
            else
            {
                lblEsado.Text = "Correo o contraseña incorrecto";
                
                lblEsado.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}