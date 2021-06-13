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
       
        public string Nickname { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        public string LastName { set; get; }
        public string Tipo { set; get; }
        public int Id { set; get; }
        public int Activo { set; get; }

        public Usuario(MySqlDataReader dataReader)
        {
            Nickname = dataReader.GetString("NICKNAME");
            Password = dataReader.GetString("CONTRASENA");
            Name = dataReader.GetString("NOMBRE");
            LastName = dataReader.GetString("APELLIDO");
            Tipo = dataReader.GetString("TIPO");
            Id = dataReader.GetInt32("ID_USUARIO");
            Activo = dataReader.GetInt32("IS_ACTIVE");
        }
        public Usuario() { }
 
    }
}
