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
        public int Reacciones { set; get; }
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
            //Contenido = SplitInParts(Contenido, 3);
            // Fecha = dataRow.GetDateTime("FECHA");
            Categoria = dataRow.GetString("ID_CATEGORIA");
            Reacciones = dataRow.GetInt32("REACCIONES_COUNT");
            Database db = new Database();
             Autor = db.GetUsuarioByID(dataRow.GetInt32("AUTOR"));
        }

        internal void AddLike(Usuario loggedUser)
        {
            Database db = new Database();
            string sql = String.Format("CALL Add_Like ({0},{1})", Id, loggedUser.Id);
            db.ExcecuteSql(sql, new List<string[]>());
        }
    }
}
