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
            nuevousuario.GetAllUsuarios();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            nuevousuario.GetAllUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nuevousuario.GetAllUsuarios();
            if (VerificarUsuario())
            {
                MessageBox.Show("Este nombre de usuario ya existe, favor de seleccionar otro");
            }
            else
            {
                nuevousuario.SetUsuario(textBox1.Text, textBox2.Text, textBox5.Text, textBox6.Text);
            }
            nuevousuario.GetAllUsuarios();
            MessageBox.Show("Usuario creado con éxito");
        }

        bool VerificarUsuario()
        {
            nickname = nuevousuario.ComprobarUsuario(textBox1.Text);
            if (nickname)
            {
                return true;
            }
            return false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(";"))
            {
                textBox1.Text = textBox1.Text.Replace(";","");
            }
            if (textBox1.Text.Contains("'"))
            {
                textBox1.Text = textBox1.Text.Replace("'", "");
            }
            if (textBox1.Text.Contains('"'))
            {
                textBox1.Text = textBox1.Text.Replace('"', ' ');
            }
            if (textBox1.Text.Contains(" "))
            {
                textBox1.Text = textBox1.Text.Replace(" ", "");
            }
        }
    }
}
