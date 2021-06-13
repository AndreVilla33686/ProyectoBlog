using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyectoBlog.Modelos
{
    public class Categoria
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }

        public Categoria(MySqlDataReader dataRow)
        {

            Id = dataRow.GetInt32("ID_CATEGORIA");
            Descripcion =dataRow.GetString("DESCRIPCION");
        }

    }
}