namespace CapaPresentacion
{
    partial class Login
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
            lbl_cedula = new Label();
            lbl_contrasena = new Label();
            txt_cedula = new TextBox();
            txt_contrasena = new TextBox();
            btn_cancelar = new Button();
            btn_entrar = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cedula.ForeColor = Color.PeachPuff;
            lbl_cedula.Location = new Point(116, 110);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(66, 28);
            lbl_cedula.TabIndex = 0;
            lbl_cedula.Text = "Cédula";
            // 
            // lbl_contrasena
            // 
            lbl_contrasena.AutoSize = true;
            lbl_contrasena.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_contrasena.ForeColor = Color.PeachPuff;
            lbl_contrasena.Location = new Point(99, 180);
            lbl_contrasena.Name = "lbl_contrasena";
            lbl_contrasena.Size = new Size(102, 28);
            lbl_contrasena.TabIndex = 1;
            lbl_contrasena.Text = "Contraseña";
            // 
            // txt_cedula
            // 
            txt_cedula.BackColor = Color.PeachPuff;
            txt_cedula.BorderStyle = BorderStyle.FixedSingle;
            txt_cedula.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cedula.Location = new Point(50, 141);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(200, 36);
            txt_cedula.TabIndex = 2;
            // 
            // txt_contrasena
            // 
            txt_contrasena.BackColor = Color.PeachPuff;
            txt_contrasena.BorderStyle = BorderStyle.FixedSingle;
            txt_contrasena.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contrasena.Location = new Point(50, 211);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(200, 36);
            txt_contrasena.TabIndex = 3;
            txt_contrasena.UseSystemPasswordChar = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Firebrick;
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.Location = new Point(150, 262);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(80, 38);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "limpiar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.Peru;
            btn_entrar.FlatStyle = FlatStyle.Popup;
            btn_entrar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_entrar.Location = new Point(64, 262);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(80, 38);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Iniciar Sesión";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_contrasena);
            groupBox1.Controls.Add(btn_entrar);
            groupBox1.Controls.Add(lbl_cedula);
            groupBox1.Controls.Add(btn_cancelar);
            groupBox1.Controls.Add(lbl_contrasena);
            groupBox1.Controls.Add(txt_cedula);
            groupBox1.Location = new Point(540, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 412);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(93, 26);
            label1.Name = "label1";
            label1.Size = new Size(119, 62);
            label1.TabIndex = 7;
            label1.Text = "Inicio";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LogoDelizia;
            Controls.Add(groupBox1);
            Name = "Login";
            Size = new Size(900, 600);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_cedula;
        private Label lbl_contrasena;
        private TextBox txt_cedula;
        private TextBox txt_contrasena;
        private Button btn_cancelar;
        private Button btn_entrar;
        private GroupBox groupBox1;
        private Label label1;
    }
}
