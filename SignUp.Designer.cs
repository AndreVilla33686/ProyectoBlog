
namespace ProyectoBlog
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nicknameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(34, 284);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(239, 22);
            this.lastNameBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Apellido(s)";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(34, 223);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(239, 22);
            this.nameBox.TabIndex = 24;
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Location = new System.Drawing.Point(34, 161);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(239, 22);
            this.confirmPasswordBox.TabIndex = 22;
            this.confirmPasswordBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre(s)";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(34, 98);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(239, 22);
            this.passwordBox.TabIndex = 20;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirme Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña";
            // 
            // nicknameBox
            // 
            this.nicknameBox.Location = new System.Drawing.Point(34, 39);
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.Size = new System.Drawing.Size(239, 22);
            this.nicknameBox.TabIndex = 16;
            this.nicknameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Crear cuenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 408);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nicknameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nicknameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}