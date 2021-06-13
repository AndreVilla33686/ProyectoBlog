using ProyectoBlog.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBlog
{
    public partial class ChatForm : Form
    {
        private List<Categoria> _categorias = new List<Categoria>();
        Database dbConnection;
        public ChatForm()
        {
            InitializeComponent();
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

        }
        private void LoadMensajes()
        {

        }
    }
}
