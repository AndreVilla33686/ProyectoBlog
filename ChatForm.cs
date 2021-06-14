using ProyectoBlog.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoBlog
{
    public partial class ChatForm : Form
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, String pszSubAppName, String pszSubIdList);
        private List<Categoria> _categorias = new List<Categoria>();
        private Usuario _loggedUser;
        private Conversacion _conversacion ;
        Database dbConnection;
        public ChatForm(Usuario user)
        {
            _loggedUser = user;
            InitializeComponent();
            userPermissions();
            SetWindowTheme(lvCategorias.Handle, "Explorer", null);
            dbConnection = new Database();
            LoadCategorias();
            InitTimer();

        }
        private void userPermissions()
        {
            if (_loggedUser.Tipo == "admin")
            {
                this.Size = new Size(830, 550);
                adminBox.Enabled = true;
            }
            else
            {
                this.Size = new Size(830, 460);
                adminBox.Enabled = false;
            }

            if (!_loggedUser.Activo)
            {
                txtMessage.Text = "USUARIO BLOQUEADO";
                txtMessage.Enabled = false;
                btnSendMessage.Enabled = false;
            }
        }
        private void checkUser()
        {
            _loggedUser = dbConnection.GetUsuarioByID(_loggedUser.Id);
            userPermissions();
        }
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadMensajes();
            LoadCategorias();
            checkUser();
        }
        private void LoadCategorias()
        {
            _categorias = dbConnection.GetCatalogoCategorias();
            if (lvCategorias.Items.Count == _categorias.Count) return;
            lvCategorias.Clear();
            _categorias.ForEach((cat) =>
            {
                lvCategorias.Items.Add(cat.Descripcion, cat.Id);
            });
            if (lvCategorias.Items.Count > 0)
            {
                lvCategorias.Items[0].Selected = true;
                lvCategorias.Select();
            }

        }
        private void LoadMensajes()
        {

            if (lvCategorias.SelectedItems.Count == 0)
            {
                return;
            }
            _conversacion = dbConnection.GetConversacionByCategoriaID(lvCategorias.SelectedItems[0].ImageIndex.ToString());
            if(_conversacion ==null) return;
            //if (_conversacion.Mensajes.Count == lvConversacion.Items.Count) return;
            lvConversacion.Clear();
            lvUsuarios.Clear();
            if (_conversacion == null) return;
            _conversacion.Mensajes.ForEach((mensaje) =>
            {
                string likes = "";
                if (mensaje.Reacciones > 0)
                {
                    likes= "\u2665"+mensaje.Reacciones +" ";
                }
                lvConversacion.Items.Add(mensaje.Autor.Nickname + " > "+likes + mensaje.Contenido , mensaje.Id);
                
                if(lvUsuarios.Items.Cast<ListViewItem>().ToList().Where(x => x.ImageIndex == mensaje.Autor.Id).Count() == 0)
                {
                    string isAdmin = "";
                    if (mensaje.Autor.Tipo == "admin")
                    {
                        isAdmin = "\u2605 ";
                    }
                lvUsuarios.Items.Add(String.Format(isAdmin+"{0} {1} ({2})", mensaje.Autor.Name, mensaje.Autor.LastName, mensaje.Autor.Nickname),mensaje.Autor.Id);
                }
            });
  
        }


        private void ChatForm_Load(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Por favor ingresa un mensaje.");
                return;
            }
            if( lvCategorias.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor selecciona una categoria.");
                return;
            }
            Database db = new Database();
            Mensaje mensaje = new Mensaje();
            mensaje.Autor = _loggedUser;
            mensaje.Categoria = lvCategorias.SelectedItems[0].ImageIndex.ToString();
            mensaje.Contenido = txtMessage.Text.Trim();
            db.AddNewMessage(mensaje);
            txtMessage.Text = "";
            LoadMensajes();
        }

        private void lvCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMensajes();
        }

        private void lvConversacion_DoubleClick(object sender, EventArgs e)
        {
            if(lvConversacion.SelectedItems.Count > 0)
            {
                Mensaje msj = dbConnection.GetMensaje(lvConversacion.SelectedItems[0].ImageIndex);
                msj.AddLike(_loggedUser);
                LoadMensajes();
            }
        }
    }
}
