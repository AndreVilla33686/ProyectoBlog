using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlog.Modelos
{
   public  class AdminUser: Usuario
    {
        public AdminUser(MySqlDataReader dataReader)
        {
            Nickname = dataReader.GetString("NICKNAME");
            Password = dataReader.GetString("CONTRASENA");
            Name = dataReader.GetString("NOMBRE");
            LastName = dataReader.GetString("APELLIDO");
            Tipo = dataReader.GetString("TIPO");
            Id = dataReader.GetInt32("ID_USUARIO");
            Activo = dataReader.GetInt32("IS_ACTIVE") == 1;
        }
        public void BorrarMensaje(int mensajeID)
        {
            string sql = "UPDATE MENSAJES SET VISIBLE = FALSE WHERE ID_MENSAJE = @mensajeID";
            List<string[]> parameters = new List<string[]>();
            parameters.Add(new string[] { "mensajeID", mensajeID.ToString() });
            Database db = new Database();
            db.ExcecuteSql(sql, parameters);
        }
        public void BloquearUsuario(int userID)
        {
            string sql = "UPDATE USUARIOS SET IS_ACTIVE = FALSE WHERE ID_USUARIO = @userID";
            List<string[]> parameters = new List<string[]>();
            parameters.Add(new string[] { "userID", userID.ToString() });
            Database db = new Database();
            db.ExcecuteSql(sql, parameters);
        }
        public void ReactivarUsuario(int userID)
        {
            string sql = "UPDATE USUARIOS SET IS_ACTIVE = TRUE WHERE ID_USUARIO = @userID";
            List<string[]> parameters = new List<string[]>();
            parameters.Add(new string[] { "userID", userID.ToString() });
            Database db = new Database();
            db.ExcecuteSql(sql, parameters);
        }
        public  void SwithcAccountType(int userID)
        {
            string sql = "UPDATE USUARIOS SET TIPO = (CASE WHEN TIPO = 'admin' THEN 'usuario' ELSE 'admin' END) WHERE ID_USUARIO = @userID";
            List<string[]> parameters = new List<string[]>();
            parameters.Add(new string[] { "userID", userID.ToString() });
            Database db = new Database();
            db.ExcecuteSql(sql, parameters);
        }
        public void AddCategoria(string cat) 
        {
            string sql = "INSERT INTO CAT_CATEGORIA VALUES (@cat, null, 1)";
            List<string[]> parameters = new List<string[]>();
            parameters.Add(new string[] { "cat", cat });
            Database db = new Database();
            db.ExcecuteSql(sql, parameters);
        }
        public void DeleteCategoria(int catID) 
        {
            string sql = "UPDATE CAT_CATEGORIA SET IS_ACTIVE = FALSE WHERE ID_CATEGORIA = @catID";
            List<string[]> parameters = new List<string[]>();
            parameters.Add(new string[] { "catID", catID.ToString() });
            Database db = new Database();
            db.ExcecuteSql(sql, parameters);
        }
    }
}
