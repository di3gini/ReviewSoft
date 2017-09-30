using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Web.Configuration;
using System.Configuration;

namespace ReviewSoft
{
    public class LogicaUsuarios
    {
        public string IniciarSesion(string usuario, string contraseña)
        {

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario.Contraseña AS Contraseña, Tipo_Usuario.Nombre AS Rol FROM Usuario " +
                                                "INNER JOIN Tipo_Usuario ON Tipo_Usuario.ID = Usuario.Tipo_Usuario WHERE Usuario.Email = @Usuario", conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);


                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    dr.Read();
                    string contra = dr.GetString(0);
                    if (contraseña == contra)
                    {

                        System.Web.HttpContext.Current.Session.Add("Usuario", usuario);
                        System.Web.HttpContext.Current.Session.Add("Rol", dr.GetString(1));
                        conn.Close();
                        return "correcto";
                    }
                    else
                    {
                        conn.Close();
                        return "contraseña";
                    }

                }
                else
                {
                    conn.Close();
                    return "usuario";
                }

            }

        }

        public bool insertarUsuario(string nombre, string apellido, string fecha, string correo, string contraseña, int profesion)
        {

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                conn.Open();


                SqlCommand cmd2 = new SqlCommand("INSERT INTO Usuario(Nombre, Apellido, Fecha_Nacimiento, Email, Contraseña, Profesion, Estado, Tipo_Usuario) VALUES(@Nombre,@Apellido,@Fecha_Nacimiento, @Correo, @Contraseña, @Profesion, 1, 2)", conn);
                cmd2.Parameters.AddWithValue("@Nombre", nombre);
                cmd2.Parameters.AddWithValue("@Apellido", apellido);
                cmd2.Parameters.AddWithValue("@Correo", correo);
                cmd2.Parameters.AddWithValue("@Fecha_Nacimiento", fecha);
                cmd2.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd2.Parameters.AddWithValue("@Profesion", profesion);

                cmd2.ExecuteNonQuery();
                conn.Close();

                /*SqlCommand cmd3 = new SqlCommand("SELECT ID FROM Usuario WHERE Usuario=@usuario", conn);
                cmd3.Parameters.AddWithValue("@Correo", correo);



                SqlDataReader dr = cmd3.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    dr.Close();

                    return false;
                }
                else
                {
                    cmd2.ExecuteNonQuery();
                    dr.Close();

                    return true;
                }*/
                return true;

            }
        }

        public DataTable Profesiones()
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT ID,Nombre From Profesion"), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public DataTable perfilUsuario(string usuario)
        {

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT Usuario.Nombre, Usuario.Apellido, CONVERT(VARCHAR(10), Usuario.Fecha_Nacimiento, 120) AS Fecha_Nacimiento, " + 
                    "Usuario.Email, Usuario.Contraseña,  Usuario.Profesion, Tipo_Usuario.Nombre FROM Usuario " + 
                    "INNER JOIN Tipo_Usuario ON Tipo_Usuario.ID = Usuario.Tipo_Usuario"), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
}