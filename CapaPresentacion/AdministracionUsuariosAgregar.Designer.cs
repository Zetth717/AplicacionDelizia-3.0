namespace CapaPresentacion
{
    partial class AdministracionUsuariosAgregar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            listBoxUsuarios = new ListBox();
            btnBajaUsuario = new Button();
            label11 = new Label();
            panel2 = new Panel();
            btn_ingresar = new Button();
            btnAlta = new Button();
            label9 = new Label();
            label12 = new Label();
            textCedulaAlta = new TextBox();
            label5 = new Label();
            label10 = new Label();
            label8 = new Label();
            menu_rol = new NumericUpDown();
            label1 = new Label();
            label4 = new Label();
            txt_cedula = new TextBox();
            txt_correo = new TextBox();
            label2 = new Label();
            label7 = new Label();
            txt_nombre = new TextBox();
            txt_contrasena = new TextBox();
            label3 = new Label();
            txt_telefono = new TextBox();
            txt_apellido = new TextBox();
            label6 = new Label();
            txt_direccion = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 552);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(listBoxUsuarios);
            panel3.Controls.Add(btnBajaUsuario);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(545, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 529);
            panel3.TabIndex = 22;
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.BackColor = Color.PeachPuff;
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.ItemHeight = 15;
            listBoxUsuarios.Location = new Point(23, 82);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(277, 334);
            listBoxUsuarios.TabIndex = 27;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.BackColor = Color.Peru;
            btnBajaUsuario.FlatStyle = FlatStyle.Popup;
            btnBajaUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBajaUsuario.ForeColor = SystemColors.ControlText;
            btnBajaUsuario.Location = new Point(86, 431);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(153, 36);
            btnBajaUsuario.TabIndex = 26;
            btnBajaUsuario.Text = "Baja usuario";
            btnBajaUsuario.UseVisualStyleBackColor = false;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.PeachPuff;
            label11.Location = new Point(101, 5);
            label11.Name = "label11";
            label11.Size = new Size(111, 28);
            label11.TabIndex = 24;
            label11.Text = "Baja usuario";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_ingresar);
            panel2.Controls.Add(btnAlta);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textCedulaAlta);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(menu_rol);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_cedula);
            panel2.Controls.Add(txt_correo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(txt_contrasena);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_telefono);
            panel2.Controls.Add(txt_apellido);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_direccion);
            panel2.Location = new Point(6, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(533, 529);
            panel2.TabIndex = 21;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.Peru;
            btn_ingresar.FlatStyle = FlatStyle.Popup;
            btn_ingresar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.ForeColor = SystemColors.ControlText;
            btn_ingresar.Location = new Point(314, 220);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(153, 36);
            btn_ingresar.TabIndex = 16;
            btn_ingresar.Text = "Ingresar usuario";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.Peru;
            btnAlta.FlatStyle = FlatStyle.Popup;
            btnAlta.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlta.ForeColor = SystemColors.ControlText;
            btnAlta.Location = new Point(316, 429);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(153, 36);
            btnAlta.TabIndex = 23;
            btnAlta.Text = "Alta usuario";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.PeachPuff;
            label9.Location = new Point(192, 5);
            label9.Name = "label9";
            label9.Size = new Size(141, 28);
            label9.TabIndex = 22;
            label9.Text = "Ingresar usuario";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.PeachPuff;
            label12.Location = new Point(286, 330);
            label12.Name = "label12";
            label12.Size = new Size(66, 28);
            label12.TabIndex = 23;
            label12.Text = "Cédula";
            // 
            // textCedulaAlta
            // 
            textCedulaAlta.BackColor = Color.PeachPuff;
            textCedulaAlta.BorderStyle = BorderStyle.FixedSingle;
            textCedulaAlta.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCedulaAlta.Location = new Point(286, 361);
            textCedulaAlta.Name = "textCedulaAlta";
            textCedulaAlta.Size = new Size(225, 36);
            textCedulaAlta.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PeachPuff;
            label5.Location = new Point(308, 121);
            label5.Name = "label5";
            label5.Size = new Size(38, 28);
            label5.TabIndex = 12;
            label5.Text = "Rol";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.PeachPuff;
            label10.Location = new Point(346, 284);
            label10.Name = "label10";
            label10.Size = new Size(109, 28);
            label10.TabIndex = 23;
            label10.Text = "Alta usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.PeachPuff;
            label8.Location = new Point(19, 331);
            label8.Name = "label8";
            label8.Size = new Size(79, 28);
            label8.TabIndex = 14;
            label8.Text = "Teléfono";
            // 
            // menu_rol
            // 
            menu_rol.BackColor = Color.PeachPuff;
            menu_rol.BorderStyle = BorderStyle.FixedSingle;
            menu_rol.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_rol.Location = new Point(308, 152);
            menu_rol.Name = "menu_rol";
            menu_rol.Size = new Size(38, 36);
            menu_rol.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PeachPuff;
            label4.Location = new Point(20, 400);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 6;
            label4.Text = "Correo";
            // 
            // txt_cedula
            // 
            txt_cedula.BackColor = Color.PeachPuff;
            txt_cedula.BorderStyle = BorderStyle.FixedSingle;
            txt_cedula.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cedula.Location = new Point(19, 82);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(225, 36);
            txt_cedula.TabIndex = 1;
            // 
            // txt_correo
            // 
            txt_correo.BackColor = Color.PeachPuff;
            txt_correo.BorderStyle = BorderStyle.FixedSingle;
            txt_correo.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_correo.Location = new Point(19, 431);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(225, 36);
            txt_correo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(19, 121);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.PeachPuff;
            label7.Location = new Point(279, 51);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 8;
            label7.Text = "Contraseña";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.PeachPuff;
            txt_nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(19, 152);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 36);
            txt_nombre.TabIndex = 3;
            // 
            // txt_contrasena
            // 
            txt_contrasena.BackColor = Color.PeachPuff;
            txt_contrasena.BorderStyle = BorderStyle.FixedSingle;
            txt_contrasena.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contrasena.Location = new Point(286, 82);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(225, 36);
            txt_contrasena.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PeachPuff;
            label3.Location = new Point(19, 191);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.PeachPuff;
            txt_telefono.BorderStyle = BorderStyle.FixedSingle;
            txt_telefono.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_telefono.Location = new Point(19, 361);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(225, 36);
            txt_telefono.TabIndex = 15;
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.PeachPuff;
            txt_apellido.BorderStyle = BorderStyle.FixedSingle;
            txt_apellido.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_apellido.Location = new Point(19, 222);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(225, 36);
            txt_apellido.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PeachPuff;
            label6.Location = new Point(19, 261);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 10;
            label6.Text = "Dirección";
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.PeachPuff;
            txt_direccion.BorderStyle = BorderStyle.FixedSingle;
            txt_direccion.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_direccion.Location = new Point(19, 292);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(225, 36);
            txt_direccion.TabIndex = 11;
            // 
            // AdministracionUsuariosAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoDelizia;
            Controls.Add(panel1);
            Name = "AdministracionUsuariosAgregar";
            Size = new Size(900, 600);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txt_direccion;
        private Label label6;
        private TextBox txt_contrasena;
        private Label label7;
        private TextBox txt_correo;
        private Label label4;
        private TextBox txt_apellido;
        private Label label3;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_cedula;
        private Label label1;
        private TextBox txt_telefono;
        private Label label8;
        private Button btn_ingresar;
        private NumericUpDown menu_rol;
        private Panel panel2;
        private Label label9;
        private Panel panel3;
        private Label label12;
        private TextBox textCedulaAlta;
        private Label label11;
        private Label label10;
        private Button btnBajaUsuario;
        private Button btnAlta;
        private ListBox listBoxUsuarios;
    }
}
