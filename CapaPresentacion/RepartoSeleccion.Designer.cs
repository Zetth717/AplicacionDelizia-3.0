namespace CapaPresentacion
{
    partial class RepartoSeleccion
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
            pan_pedidos = new Panel();
            btn_volver = new Button();
            SuspendLayout();
            // 
            // pan_pedidos
            // 
            pan_pedidos.AutoScroll = true;
            pan_pedidos.AutoScrollMargin = new Size(10, 10);
            pan_pedidos.BackColor = Color.Transparent;
            pan_pedidos.BorderStyle = BorderStyle.FixedSingle;
            pan_pedidos.Location = new Point(12, 38);
            pan_pedidos.Name = "pan_pedidos";
            pan_pedidos.Size = new Size(871, 492);
            pan_pedidos.TabIndex = 7;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.Firebrick;
            btn_volver.FlatStyle = FlatStyle.Popup;
            btn_volver.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_volver.ForeColor = Color.Black;
            btn_volver.Location = new Point(803, 545);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(80, 38);
            btn_volver.TabIndex = 6;
            btn_volver.Text = "Atrás";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // RepartoSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.FondoDelizia;
            Controls.Add(pan_pedidos);
            Controls.Add(btn_volver);
            Name = "RepartoSeleccion";
            Size = new Size(900, 600);
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_pedidos;
        private Button btn_volver;
    }
}
