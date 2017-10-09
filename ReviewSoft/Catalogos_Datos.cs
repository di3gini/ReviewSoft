using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;

namespace ReviewSoft
{
    public class Catalogos_Datos
    {
        public DataTable TodoSoftware()
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT S.ID_Software, S.Nombre, S.URL, S.Descripcion, S.Demo," + 
                    "S.Soporte_linea, S.Precio_Basico, S.Precio_Premium, S.Logo, S.Usuarios, S.Fecha_Publicacion, E.ID_Empresa, " + 
                    "TL.ID_Tipo_Licencia, S.Estado FROM Software S INNER JOIN Empresa E ON S.Empresa_ID_Empresa = E.ID_Empresa " + 
                    "INNER JOIN Tipo_Licencia TL ON S.Tipo_Licencia_ID_Tipo_Licencia = TL.ID_Tipo_Licencia"), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public DataTable TodaPlataforma()
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Plataforma"), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public DataTable TodasLicencias()
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Tipo_Licencia"), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public DataTable TodaCategoria()
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Categoria"), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public DataTable TodaProfesion()
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Profesion"), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public DataTable TodaEmpresa()
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Empresa"), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public DataTable TodaMetrica()
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConexionRS"].ConnectionString))
            {
                SqlCommand consulta = new SqlCommand(string.Format("SELECT M.ID_Metrica, M.Nombre, M.Descripcion, S.ID_Software, M.Estado" + 
                    "FROM Metrica M INNER JOIN Software S ON M.Software_ID_Software = S.ID_Software "), conn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
}