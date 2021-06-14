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

        }
        public void ReactivarUsuario(int userID)
        {

        }
        public  void SwithcAccountType(int userID)
        {

        }
        public void AddCategoria(string cat) {
        }
        public void DeleteCategoria(int catID) { 
        }
    }
}
