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
    public partial class SignUp : Form
    {
        Modelos.Usuario nuevousuario = new Modelos.Usuario();
        DataTable usuarios = new DataTable();
        bool nickname;
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevousuario.nickname = nicknameBox.Text;
            nuevousuario.password = passwordBox.Text;
            nuevousuario.name = nameBox.Text;
            nuevousuario.lastName = lastNameBox.Text;
            nuevoUsuario.tipo = "usuario";
            Database db = new Database();
            db.CreateNewUser(nuevousuario);
            MessageBox.Show("Usuario creado con éxito");
        }

        bool VerificarUsuario()
        {
            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordBox.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (nicknameBox.Text.Contains(";"))
            {
                nicknameBox.Text = nicknameBox.Text.Replace(";","");
            }
            if (nicknameBox.Text.Contains("'"))
            {
                nicknameBox.Text = nicknameBox.Text.Replace("'", "");
            }
            if (nicknameBox.Text.Contains('"'))
            {
                nicknameBox.Text = nicknameBox.Text.Replace('"', ' ');
            }
            if (nicknameBox.Text.Contains(" "))
            {
                nicknameBox.Text = nicknameBox.Text.Replace(" ", "");
            }
        }
    }
}
