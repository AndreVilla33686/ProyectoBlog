using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlog.Modelos
{

   public class Conversacion
    {
        public int ID { get; set; }
        public List<Mensaje> Mensajes { get; set; }
        public List<Usuario> Participantes { get; set; }
        public Conversacion()
        {
            Mensajes = new List<Mensaje>();
            Participantes = new List<Usuario>();
        }

        public Conversacion(MySqlDataReader dataReader)
        {
            ID = dataReader.GetInt32("ID_CATEGORIA");
        }
    }
}
