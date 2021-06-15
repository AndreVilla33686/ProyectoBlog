
namespace ProyectoBlog
{
    partial class ChatForm
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
            this.lvCategorias = new System.Windows.Forms.ListView();
            this.lvConversacion = new System.Windows.Forms.ListView();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminBox = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.adminBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCategorias
            // 
            this.lvCategorias.FullRowSelect = true;
            this.lvCategorias.HideSelection = false;
            this.lvCategorias.Location = new System.Drawing.Point(20, 28);
            this.lvCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvCategorias.Name = "lvCategorias";
            this.lvCategorias.Size = new System.Drawing.Size(199, 477);
            this.lvCategorias.TabIndex = 0;
            this.lvCategorias.UseCompatibleStateImageBehavior = false;
            this.lvCategorias.View = System.Windows.Forms.View.List;
            this.lvCategorias.SelectedIndexChanged += new System.EventHandler(this.lvCategorias_SelectedIndexChanged);
            // 
            // lvConversacion
            // 
            this.lvConversacion.FullRowSelect = true;
            this.lvConversacion.HideSelection = false;
            this.lvConversacion.Location = new System.Drawing.Point(228, 28);
            this.lvConversacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvConversacion.MultiSelect = false;
            this.lvConversacion.Name = "lvConversacion";
            this.lvConversacion.Size = new System.Drawing.Size(524, 437);
            this.lvConversacion.TabIndex = 1;
            this.lvConversacion.UseCompatibleStateImageBehavior = false;
            this.lvConversacion.View = System.Windows.Forms.View.List;
            this.lvConversacion.DoubleClick += new System.EventHandler(this.lvConversacion_DoubleClick);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(653, 470);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(100, 39);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Enviar";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(228, 474);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(404, 30);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = ">> CATEGORIAS <<";
            // 
            // adminBox
            // 
            this.adminBox.Controls.Add(this.button6);
            this.adminBox.Controls.Add(this.button5);
            this.adminBox.Controls.Add(this.button4);
            this.adminBox.Controls.Add(this.button3);
            this.adminBox.Controls.Add(this.button2);
            this.adminBox.Controls.Add(this.button1);
            this.adminBox.Location = new System.Drawing.Point(21, 517);
            this.adminBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBox.Name = "adminBox";
            this.adminBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBox.Size = new System.Drawing.Size(883, 91);
            this.adminBox.TabIndex = 5;
            this.adminBox.TabStop = false;
            this.adminBox.Text = "ACCIONES DE ADMINISTRADOR";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(447, 23);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 60);
            this.button6.TabIndex = 14;
            this.button6.Text = "Cambiar Tipo de Cuenta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(299, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 60);
            this.button5.TabIndex = 13;
            this.button5.Text = "Reactivar Usuario";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(736, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 60);
            this.button4.TabIndex = 12;
            this.button4.Text = "Eliminar Categoria";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(591, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "Agregar Categoria";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Bloquear Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Eliminar Mensaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = ">> USUARIOS <<";
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.HideSelection = false;
            this.lvUsuarios.Location = new System.Drawing.Point(761, 28);
            this.lvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(305, 477);
            this.lvUsuarios.TabIndex = 6;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.List;
            this.lvUsuarios.SelectedIndexChanged += new System.EventHandler(this.lvUsuarios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = ">> CONVERSACION <<";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(5, 3);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(21, 23);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "X";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvUsuarios);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.lvConversacion);
            this.Controls.Add(this.lvCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatForm";
            this.Text = "Cetys Chat";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.adminBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCategorias;
        private System.Windows.Forms.ListView lvConversacion;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox adminBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label4;
    }
}