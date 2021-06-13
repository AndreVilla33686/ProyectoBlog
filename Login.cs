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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
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
        }
        void InicioSesion()
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            Usuario loggedUser = db.GetUsuarioByNameAndPassword(nickNameBox.Text, passwordBox.Text);
            if(loggedUser == null){
                MessageBox.Show("El Usuario no existe o la contrasena es incorrecta.");
                return;
            }
            ChatForm chat = new ChatForm(loggedUser);
            chat.Show();
           // this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
