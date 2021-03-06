using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProyectoBlog.Modelos
{
    class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Database()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "cetys.cp1cqffuqjuh.us-east-2.rds.amazonaws.com";
            database = "chat";
            uid = "admin";
            password = "cetyschat#1";
            string connectionString;
            connectionString = "SERVER=" + server + ";port=3306;" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SSL Mode=None";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                if(connection.State == ConnectionState.Open)
                {
                    return true;
                }
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        internal void CreateNewUser(Usuario nuevousuario)
        {
            connection.Open();
            string query = "INSERT INTO USUARIOS VALUES ('" + nuevousuario.Nickname + "', '" + nuevousuario.Password + "', '" + nuevousuario.Name + "', '" + nuevousuario.LastName + "', 'usuario', 'null', '1');";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
            //throw new NotImplementedException();
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void AddNewMessage(Mensaje mensaje)
        {
            string sql = "INSERT INTO MENSAJES(ID_CATEGORIA, AUTOR, CONTENIDO) VALUES(@cat, @autor, @contenido)";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("cat", mensaje.Categoria);
                cmd.Parameters.AddWithValue("autor", mensaje.Autor.Id);
                cmd.Parameters.AddWithValue("contenido", mensaje.Contenido);
                cmd.Connection = connection;
                cmd.ExecuteReader();
                this.CloseConnection();
            }
        }

        public void ExcecuteSql(string query, List<string[]> paramsList)
        {
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                paramsList.ForEach((p) =>
                {
                    cmd.Parameters.AddWithValue(p[0], p[1]);
                });
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteReader();

                //close connection
                this.CloseConnection();
            }
        }

        public Conversacion GetConversacionByCategoriaID(string id)
        {
            Conversacion conv = null;
            string query = String.Format("SELECT *, (SELECT COUNT(*) from REACCIONES WHERE ID_MENSAJE= MENSAJES.ID_MENSAJE) as REACCIONES_COUNT from MENSAJES where ID_CATEGORIA = {0} AND VISIBLE = TRUE", id);



            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {

                conv = new Conversacion();
                conv.ID = Int32.Parse(id);
                while (dataReader.Read())
                {
                    
                    conv.Mensajes.Add(new Mensaje(dataReader));
                  
                }
                }
                dataReader.Close();
                this.CloseConnection();
            }

            return conv;
        }

        private List<Usuario> GetParticipantes(int iD)
        {
            List<Usuario> list = new List<Usuario>();
            string query = "SELECT * FROM MENSAJES WHERE ID_CATEGORIA =" + iD;
            return list;
        }

        public List<Categoria> GetCatalogoCategorias()
        {
            string query = "SELECT * FROM CAT_CATEGORIA WHERE IS_ACTIVE = TRUE ORDER BY 1";

            List<Categoria> list = new List<Categoria>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new Categoria(dataReader));
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        public Mensaje GetMensaje(int id)
        {
            Mensaje mensaje = null;
            string query = String.Format("SELECT *, (SELECT COUNT(*) from REACCIONES WHERE ID_MENSAJE= {0}) as REACCIONES_COUNT from MENSAJES where id_mensaje = {0}  AND VISIBLE = TRUE", id);


            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    mensaje = new Mensaje(dataReader);
                }
                dataReader.Close();
                this.CloseConnection();
            }
            return mensaje;
        }
        public object GetUsuarioByNameAndPassword(string name, string password)
        {
            string query = "SELECT * FROM USUARIOS WHERE NICKNAME = '" + name + "' AND CONTRASENA = '" + password + "' ;";

            Object activeUser =null;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetString("tipo") == "admin")
                    {

                        activeUser = new AdminUser(dataReader);
                    }
                    else
                    {
                    activeUser = new Usuario(dataReader);
                    }
                }

                dataReader.Close();
                this.CloseConnection();
                return activeUser;
            }
            else
            {
                return activeUser;
            }
        }

        public Usuario GetUsuarioByID(int id)
        {
            string query = "SELECT * FROM USUARIOS WHERE ID_USUARIO = '"+id+"';";

            Usuario activeUser = new Usuario();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                DataTable dt = dataReader.GetSchemaTable();
                while (dataReader.Read())
                {
                    activeUser = new Usuario(dataReader);
                }

                dataReader.Close();
                this.CloseConnection();
                return activeUser;
            }
            else
            {
                return activeUser;
            }
        }
    }
}
