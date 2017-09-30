using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReviewSoft
{
    public partial class Encabezado : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                
                if (Session["Rol"].ToString() == "Administrador")
                {

                    nav.InnerHtml = "<ul>" +
                          "<li><a href=\"..\\Inicio.aspx\"> INICIO </a></li>" +
                          "<li><a href= \"..\\Usuarios\\Usuarios.aspx\">USUARIOS</a></li>" +
                          "<li><a href=\"..\\Proyectos\\Proyectos.aspx\">PROYECTOS</a></li>" +
                             "<li><a href=\"..\\Casos\\Casos.aspx\">CASOS</a></li>" +
                             "<li><a href=\"..\\Perfil.aspx\">" + Session["Usuario"].ToString() + "</a></li>" +
                          "<li><a class=\"button special\" href=\"..\\CerrarSesion.aspx\">CERRAR SESIÓN</a></li> </ul>";
                }
                else
                {
                    nav.InnerHtml = "<ul>" +
                          "<li><a href=\"..\\Inicio.aspx\"> INICIO </a></li>" +
                             "<li><a href=\"..\\Casos\\Casos.aspx\">CASOS</a></li>" +
                             "<li><a href=\"..\\Perfil.aspx\">" + Session["Usuario"].ToString() + "</a></li>" +
                          "<li><a class=\"button special\" href=\"..\\CerrarSesion.aspx\">CERRAR SESIÓN</a></li> </ul>";
                }
            }
            else
            {
                nav.InnerHtml = "<ul>" +
                          "<li><a href=\"..\\IniciarSesion.aspx\"> LOGIN </a></li>" +
                          "<li><a class=\"button special\" href=\"..\\Registrarse.aspx\">Registrarse</a></li> </ul>";
            }
        }
        
    }
}