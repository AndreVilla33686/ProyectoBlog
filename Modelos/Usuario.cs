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
        Modelos.Database usuarios = new Modelos.Database();
        public DataTable allUsuarios;
        public DataRow user;
        DataSet listaUsuarios = new DataSet();
        public void GetAllUsuarios()
        {
            allUsuarios = usuarios.TablaContacto(allUsuarios, listaUsuarios);
        }

        public bool ComprobarUsuario(string x)
        {
            foreach (DataRow row in allUsuarios.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (Convert.ToString(row[i]) == x)
                    {
                        user = row;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ComprobarContrasena(string x)
        {
            if (Convert.ToString(user[1]) == x)
            {
                return true;
            }
            return false;
        }

        public string GetUsuario()
        {
            return Convert.ToString(user[0]);
        }
        public string GetNombre()
        {
            return Convert.ToString(user[2]);
        }
        public string GetApellido()
        {
            return Convert.ToString(user[3]);
        }
        public string GetTipo()
        {
            return Convert.ToString(user[4]);
        }
        public int GetID()
        {
            return Convert.ToInt32(user[5]);
        }
        public void SetUsuario(string a, string b, string c, string d)
        {
            usuarios.SetUsuario(a, b, c, d);
        }
    }
}
