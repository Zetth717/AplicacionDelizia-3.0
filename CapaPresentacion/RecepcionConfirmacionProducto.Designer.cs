﻿namespace CapaPresentacion
{
    partial class RecepcionConfirmacionProducto
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
            lbl_contenido = new Label();
            SuspendLayout();
            // 
            // lbl_contenido
            // 
            lbl_contenido.AutoSize = true;
            lbl_contenido.BackColor = Color.Peru;
            lbl_contenido.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_contenido.Location = new Point(3, 9);
            lbl_contenido.Name = "lbl_contenido";
            lbl_contenido.Size = new Size(523, 28);
            lbl_contenido.TabIndex = 0;
            lbl_contenido.Text = "Cantidad | Nombre del producto | Precio unitario | Precio Total";
            // 
            // RecepcionConfirmacionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbl_contenido);
            Name = "RecepcionConfirmacionProducto";
            Size = new Size(359, 47);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_contenido;
    }
}
