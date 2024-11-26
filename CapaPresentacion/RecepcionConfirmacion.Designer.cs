namespace CapaPresentacion
{
    partial class RecepcionConfirmacion
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
            btn_anterior = new Button();
            btn_confirmar = new Button();
            pan_contenido = new Panel();
            pan_detalles = new Panel();
            lbl_total = new Label();
            pan_productos = new Panel();
            lbl_subtitulo1 = new Label();
            pan_cliente = new Panel();
            lbl_subtitulo = new Label();
            lbl_direccion = new Label();
            txt_direccion = new TextBox();
            lbl_telefono = new Label();
            txt_telefono = new TextBox();
            lbl_apellido = new Label();
            txt_apellido = new TextBox();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            pan_contenido.SuspendLayout();
            pan_detalles.SuspendLayout();
            pan_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.Firebrick;
            btn_anterior.FlatStyle = FlatStyle.Popup;
            btn_anterior.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_anterior.Location = new Point(63, 544);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(108, 38);
            btn_anterior.TabIndex = 0;
            btn_anterior.Text = "Anterior";
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // btn_confirmar
            // 
            btn_confirmar.BackColor = Color.Olive;
            btn_confirmar.FlatStyle = FlatStyle.Popup;
            btn_confirmar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_confirmar.Location = new Point(725, 544);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(108, 38);
            btn_confirmar.TabIndex = 1;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // pan_contenido
            // 
            pan_contenido.BackColor = Color.Transparent;
            pan_contenido.BorderStyle = BorderStyle.FixedSingle;
            pan_contenido.Controls.Add(pan_detalles);
            pan_contenido.Controls.Add(pan_cliente);
            pan_contenido.Location = new Point(63, 75);
            pan_contenido.Name = "pan_contenido";
            pan_contenido.Size = new Size(770, 391);
            pan_contenido.TabIndex = 2;
            // 
            // pan_detalles
            // 
            pan_detalles.BackColor = Color.Peru;
            pan_detalles.BorderStyle = BorderStyle.FixedSingle;
            pan_detalles.Controls.Add(lbl_total);
            pan_detalles.Controls.Add(pan_productos);
            pan_detalles.Controls.Add(lbl_subtitulo1);
            pan_detalles.Location = new Point(392, 3);
            pan_detalles.Name = "pan_detalles";
            pan_detalles.Size = new Size(373, 385);
            pan_detalles.TabIndex = 1;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total.Location = new Point(3, 336);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(113, 28);
            lbl_total.TabIndex = 2;
            lbl_total.Text = "$Precio total";
            // 
            // pan_productos
            // 
            pan_productos.AutoScroll = true;
            pan_productos.BackColor = Color.PeachPuff;
            pan_productos.BorderStyle = BorderStyle.FixedSingle;
            pan_productos.Location = new Point(3, 33);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(367, 300);
            pan_productos.TabIndex = 1;
            // 
            // lbl_subtitulo1
            // 
            lbl_subtitulo1.AutoSize = true;
            lbl_subtitulo1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_subtitulo1.Location = new Point(3, 2);
            lbl_subtitulo1.Name = "lbl_subtitulo1";
            lbl_subtitulo1.Size = new Size(164, 28);
            lbl_subtitulo1.TabIndex = 0;
            lbl_subtitulo1.Text = "Detalles del pedido";
            // 
            // pan_cliente
            // 
            pan_cliente.BackColor = Color.Peru;
            pan_cliente.BorderStyle = BorderStyle.FixedSingle;
            pan_cliente.Controls.Add(lbl_subtitulo);
            pan_cliente.Controls.Add(lbl_direccion);
            pan_cliente.Controls.Add(txt_direccion);
            pan_cliente.Controls.Add(lbl_telefono);
            pan_cliente.Controls.Add(txt_telefono);
            pan_cliente.Controls.Add(lbl_apellido);
            pan_cliente.Controls.Add(txt_apellido);
            pan_cliente.Controls.Add(lbl_nombre);
            pan_cliente.Controls.Add(txt_nombre);
            pan_cliente.Location = new Point(3, 3);
            pan_cliente.Name = "pan_cliente";
            pan_cliente.Size = new Size(373, 385);
            pan_cliente.TabIndex = 0;
            // 
            // lbl_subtitulo
            // 
            lbl_subtitulo.AutoSize = true;
            lbl_subtitulo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_subtitulo.Location = new Point(10, 10);
            lbl_subtitulo.Name = "lbl_subtitulo";
            lbl_subtitulo.Size = new Size(162, 28);
            lbl_subtitulo.TabIndex = 10;
            lbl_subtitulo.Text = "Detalles del cliente";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_direccion.Location = new Point(10, 257);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(87, 28);
            lbl_direccion.TabIndex = 7;
            lbl_direccion.Text = "Dirección";
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.PeachPuff;
            txt_direccion.BorderStyle = BorderStyle.FixedSingle;
            txt_direccion.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_direccion.Location = new Point(10, 288);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(353, 36);
            txt_direccion.TabIndex = 6;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.BackColor = Color.Transparent;
            lbl_telefono.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefono.Location = new Point(10, 187);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(79, 28);
            lbl_telefono.TabIndex = 5;
            lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.PeachPuff;
            txt_telefono.BorderStyle = BorderStyle.FixedSingle;
            txt_telefono.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_telefono.Location = new Point(10, 218);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(353, 36);
            txt_telefono.TabIndex = 4;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_apellido.Location = new Point(10, 117);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(77, 28);
            lbl_apellido.TabIndex = 3;
            lbl_apellido.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.PeachPuff;
            txt_apellido.BorderStyle = BorderStyle.FixedSingle;
            txt_apellido.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_apellido.Location = new Point(10, 148);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(353, 36);
            txt_apellido.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre.Location = new Point(10, 47);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(75, 28);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.PeachPuff;
            txt_nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(10, 78);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(353, 36);
            txt_nombre.TabIndex = 0;
            // 
            // RecepcionConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoDelizia;
            Controls.Add(pan_contenido);
            Controls.Add(btn_confirmar);
            Controls.Add(btn_anterior);
            Name = "RecepcionConfirmacion";
            Size = new Size(900, 600);
            pan_contenido.ResumeLayout(false);
            pan_detalles.ResumeLayout(false);
            pan_detalles.PerformLayout();
            pan_cliente.ResumeLayout(false);
            pan_cliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_anterior;
        private Button btn_confirmar;
        private Panel pan_contenido;
        private Panel pan_detalles;
        private Panel pan_cliente;
        private Label label5;
        private TextBox textBox5;
        private Label lbl_direccion;
        private TextBox txt_direccion;
        private TextBox textBox4;
        private Label lbl_telefono;
        private TextBox txt_telefono;
        private TextBox textBox3;
        private Label lbl_apellido;
        private TextBox txt_apellido;
        private TextBox textBox2;
        private Label lbl_nombre;
        private TextBox txt_nombre;
        private Panel pan_productos;
        private Label lbl_subtitulo1;
        private Label lbl_total;
        private Label lbl_subtitulo;
    }
}
