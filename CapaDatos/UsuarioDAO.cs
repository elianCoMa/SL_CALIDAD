using CapaEntidad;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class UsuarioDAO
    {
        Usuario usuario = new Usuario();
        MySqlConnection connectionMySql = new MySqlConnection("server=localhost;database=farmacia;user=root;password=;");
        SqlConnection cn = new SqlConnection("Server=LAPTOP-V79H8RNG\\SQLEXPRESS;Database=FARMACIA;Integrated Security=true;");


        public DataTable listaUsuarioMysql()
        {
            connectionMySql.Close();
            connectionMySql.Open();

            DataTable dt = new DataTable();
            try
            {
                string query = "select u.idusuario,u.usuario,u.clave,e.nombreEstado  from usuario as u inner join ESTADO as e on u.estadoUsuario=e.idEstado;";
                MySqlCommand da = new MySqlCommand(query, connectionMySql);
                MySqlDataAdapter da2 = new MySqlDataAdapter(da);

                da2.Fill(dt);
                connectionMySql.Close();
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;
        }
        public DataTable listaUsuarioSql()
        {
            DataTable dt = new DataTable();
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("select u.idusuario,u.usuario,u.clave,e.nombreEstado  from USUARIO u inner join ESTADO e on u.estadoUsuario=e.idEstado;", cn);
                da.Fill(dt);
                cn.Close();
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;
        }

        public Usuario BuscarUsuario(int id, string tipo)
        {
            Usuario usu = new Usuario();
            if (tipo == "sql")
            {

                SqlDataAdapter da = new SqlDataAdapter("select *  from USUARIO where docusuario = " + id + " and estadousuario = 1", cn);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                DataRow row = dataTable.Rows[0];
                usu.idusuario = Convert.ToInt16(row["idusuario"]);
                usu.usuario = row["usuario"].ToString();
                usu.clave = row["clave"].ToString(); 
            }
            else if (tipo == "mysql")
            {
                string query = "select *  from USUARIO where docusuario = "+ id+ " and estadousuario = 1";
                MySqlCommand da = new MySqlCommand(query, connectionMySql);
                MySqlDataAdapter da2 = new MySqlDataAdapter(da);
                DataTable dataTable = new DataTable();
                da2.Fill(dataTable);
                DataRow row = dataTable.Rows[0];
                usu.idusuario = Convert.ToInt16(row["idusuario"]);
                usu.usuario = row["usuario"].ToString();
                usu.clave = row["clave"].ToString();
                
            }
            return usu;

        }
        public string VALIDARUsuario(string usuario,string clave, string tipo)
        {
            Usuario usu = new Usuario();
            string mensaje = null;
            if (tipo == "sql")
            {

                string query = "select *  from USUARIO where usuario = '" + usuario + "' and clave = '"+ clave+"' and estadousuario = 1";
                SqlCommand command = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    mensaje = reader[1].ToString();
                }
                
            }
            else if (tipo == "mysql")
            {
                string query = "select *  from USUARIO where docusuario = '" + usuario + "' and clave = '" + clave + "' and estadousuario = 1";
                MySqlCommand da = new MySqlCommand(query, connectionMySql);
                connectionMySql.Open();
                MySqlDataReader reader = da.ExecuteReader();
                if (reader.Read())
                {
                    mensaje = reader[1].ToString();
                }   
            }
            return mensaje;

        }

    }
}
