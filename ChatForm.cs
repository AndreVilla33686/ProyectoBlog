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
            SetWindowTheme(lvCategorias.Handle, "Explorer", null);
            dbConnection = new Database();
            LoadCategorias();
        }
        private void LoadCategorias()
        {
            _categorias = dbConnection.GetCatalogoCategorias();
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
            lvConversacion.Clear();
            if (_conversacion == null) return;
            _conversacion.Mensajes.ForEach((mensaje) =>
            {
                lvConversacion.Items.Add(mensaje.Contenido, mensaje.Id);
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
    }
}
