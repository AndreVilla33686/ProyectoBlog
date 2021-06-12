using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlog.Modelos
{
    class Mensaje
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Fecha { get; set; }
        public string Categoria { get; set; }
        // TODO: Cambiar Autor a tipo Usuario 
        public int Autor { get; set; }

        public Mensaje()
        {

        }
        public Mensaje(DataRow dataRow)
        {
            Id = (int)dataRow["ID_MENSAJE"];
            Contenido = (string)dataRow["CONTENIDO"];
            Fecha = (string)dataRow["FECHA"];
            Categoria = (string)dataRow["ID_CATEGORIA"];
            // Autor = (int)dataRow["AUTOR"];
        }
    }
}
