using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlog.Modelos
{
    public class Usuario
    {
       
        public string nickname { set; get; }
        public string password { set; get; }
        public string name { set; get; }
        public string lastName { set; get; }
        public string tipo { set; get; }
        public int id { set; get; }
        public int activo { set; get; }

        public Usuario(MySqlDataReader dataReader)
        {
            nickname = dataReader.GetString("NICKNAME");
            password = dataReader.GetString("CONTRASENA");
            name = dataReader.GetString("NOMBRE");
            lastName = dataReader.GetString("APELLIDO");
            tipo = dataReader.GetString("TIPO");
            id = dataReader.GetInt32("ID_USUARIO");
            activo = dataReader.GetInt32("IS_ACTIVE");
        }
        public Usuario() { }
 
    }
}
