
namespace ProyectoBlog
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nickNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(434, 254);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(150, 17);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Recuperar contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "¿Olvidaste tu Contraseña?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "¿No tienes cuenta?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(388, 217);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 17);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Crear cuenta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(248, 120);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(305, 22);
            this.passwordBox.TabIndex = 12;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // nickNameBox
            // 
            this.nickNameBox.Location = new System.Drawing.Point(248, 42);
            this.nickNameBox.Name = "nickNameBox";
            this.nickNameBox.Size = new System.Drawing.Size(305, 22);
            this.nickNameBox.TabIndex = 10;
            this.nickNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nickNameBox);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nickNameBox;
        private System.Windows.Forms.Label label1;
    }
}

