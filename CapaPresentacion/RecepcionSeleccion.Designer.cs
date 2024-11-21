namespace CapaPresentacion
{
    partial class RecepcionSeleccion
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
            btn_cancelar = new Button();
            btn_siguiente = new Button();
            pan_productos = new Panel();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Peru;
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btn_cancelar.Location = new Point(31, 541);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(133, 38);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_siguiente
            // 
            btn_siguiente.BackColor = Color.Peru;
            btn_siguiente.FlatStyle = FlatStyle.Popup;
            btn_siguiente.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btn_siguiente.Location = new Point(726, 541);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(133, 38);
            btn_siguiente.TabIndex = 1;
            btn_siguiente.Text = "Siguiente";
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // pan_productos
            // 
            pan_productos.AutoScroll = true;
            pan_productos.AutoScrollMargin = new Size(10, 10);
            pan_productos.BackColor = Color.Transparent;
            pan_productos.Location = new Point(12, 38);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(871, 492);
            pan_productos.TabIndex = 2;
            // 
            // RecepcionSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoDelizia;
            Controls.Add(pan_productos);
            Controls.Add(btn_siguiente);
            Controls.Add(btn_cancelar);
            Name = "RecepcionSeleccion";
            Size = new Size(900, 600);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_siguiente;
        private Panel pan_productos;
    }
}
