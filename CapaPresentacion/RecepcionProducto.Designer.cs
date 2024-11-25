namespace CapaPresentacion
{
    partial class RecepcionProducto
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
            lbl_nombre = new Label();
            btn_restar = new Button();
            btn_sumar = new Button();
            lbl_cantidad = new Label();
            lbl_precio = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.BackColor = Color.PeachPuff;
            lbl_nombre.BorderStyle = BorderStyle.FixedSingle;
            lbl_nombre.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre.Location = new Point(4, 2);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(193, 30);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre del producto";
            lbl_nombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_restar
            // 
            btn_restar.BackColor = Color.PeachPuff;
            btn_restar.FlatStyle = FlatStyle.Popup;
            btn_restar.Font = new Font("ROG Fonts", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_restar.Location = new Point(50, 217);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(30, 30);
            btn_restar.TabIndex = 1;
            btn_restar.Text = "-";
            btn_restar.UseVisualStyleBackColor = false;
            btn_restar.Click += btn_restar_Click;
            // 
            // btn_sumar
            // 
            btn_sumar.BackColor = Color.PeachPuff;
            btn_sumar.FlatStyle = FlatStyle.Popup;
            btn_sumar.Font = new Font("ROG Fonts", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sumar.Location = new Point(118, 217);
            btn_sumar.Name = "btn_sumar";
            btn_sumar.Size = new Size(30, 30);
            btn_sumar.TabIndex = 2;
            btn_sumar.Text = "+";
            btn_sumar.UseVisualStyleBackColor = false;
            btn_sumar.Click += btn_sumar_Click;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.BackColor = Color.PeachPuff;
            lbl_cantidad.BorderStyle = BorderStyle.FixedSingle;
            lbl_cantidad.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cantidad.Location = new Point(86, 217);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(26, 30);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "0";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.BackColor = Color.PeachPuff;
            lbl_precio.Font = new Font("Segoe Print", 9F);
            lbl_precio.Location = new Point(8, 189);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(53, 21);
            lbl_precio.TabIndex = 4;
            lbl_precio.Text = "$Precio";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PeachPuff;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(4, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 178);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RecepcionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            Controls.Add(lbl_precio);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_cantidad);
            Controls.Add(btn_sumar);
            Controls.Add(btn_restar);
            Controls.Add(lbl_nombre);
            Name = "RecepcionProducto";
            Size = new Size(200, 250);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Button btn_restar;
        private Button btn_sumar;
        private Label lbl_cantidad;
        private Label lbl_precio;
        private PictureBox pictureBox1;
    }
}
