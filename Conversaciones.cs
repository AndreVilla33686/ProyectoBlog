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
    public partial class Conversaciones : Form
    {
        public string usuarioActivo, usuarioActivoNombre, usuarioActivoApellido, usuarioActivoTipo;
        public int usuarioActivoID;
        public Conversaciones()
        {
            InitializeComponent();
        }

        private void Conversaciones_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
