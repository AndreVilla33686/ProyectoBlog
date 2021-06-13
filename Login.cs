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
    public partial class Login : Form
    {
        Modelos.Usuario usuario = new Modelos.Usuario();
        bool nickname = false;
        bool password = false;
        public int id;
        public string user, nombre, apellido, tipo;
        public Login()
        {
            InitializeComponent();
            usuario.GetAllUsuarios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuario.GetAllUsuarios();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        void VerificarUsuario()
        {
            nickname = usuario.ComprobarUsuario(textBox1.Text);
            if (!nickname)
            {
                MessageBox.Show("No existe el Nombre de Usuario");
            }
            else
            {
                password = usuario.ComprobarContrasena(textBox2.Text);
                if (!password)
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
                else
                {
                    InicioSesion();
                }
            }
        }
        void InicioSesion()
        {
            id = usuario.GetID();
            user = usuario.GetUsuario();
            nombre = usuario.GetNombre();
            apellido = usuario.GetApellido();
            tipo = usuario.GetTipo();
            MessageBox.Show(tipo);
            ChatForm c = new ChatForm(usuario);
            c.Show();
            textBox1.Text = "";
            textBox2.Text = "";
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            usuario.GetAllUsuarios();
            VerificarUsuario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
