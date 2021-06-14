using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlog.Modelos
{
    public class Mensaje
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }
        public Usuario Autor { get; set; }

        public Mensaje()
        {

        }
        public void Reaccionar(int idReaccion)
        {
            string sql = String.Format("INSERT INTO REACCIONES (ID_MENSAJE, ID_CAT_REACCION, ID_USUARIO) VALUES({0},{1},{2},{3})",Id,idReaccion);
            
        }
        public Mensaje(MySqlDataReader dataRow)
        {
            Id = dataRow.GetInt32("ID_MENSAJE");
            Contenido = dataRow.GetString("CONTENIDO");
           // Fecha = dataRow.GetDateTime("FECHA");
            Categoria = dataRow.GetString("ID_CATEGORIA");
            // Autor = (int)dataRow["AUTOR"];
        }
    }
}
