namespace CapaPresentacion
{
    partial class CocinaPedidoProducto
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
            lbl_detalles = new Label();
            SuspendLayout();
            // 
            // lbl_detalles
            // 
            lbl_detalles.AutoSize = true;
            lbl_detalles.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_detalles.Location = new Point(0, 5);
            lbl_detalles.Name = "lbl_detalles";
            lbl_detalles.Size = new Size(212, 28);
            lbl_detalles.TabIndex = 0;
            lbl_detalles.Text = "Nombre del producto | 1";
            // 
            // CocinaPedidoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbl_detalles);
            Name = "CocinaPedidoProducto";
            Size = new Size(225, 37);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_detalles;
    }
}
