﻿namespace CapaPresentacion
{
    partial class CocinaMenu
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
            btn_verpedidos = new Button();
            btn_salir = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_verpedidos
            // 
            btn_verpedidos.BackColor = Color.Peru;
            btn_verpedidos.FlatStyle = FlatStyle.Popup;
            btn_verpedidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_verpedidos.Location = new Point(85, 152);
            btn_verpedidos.Name = "btn_verpedidos";
            btn_verpedidos.Size = new Size(133, 38);
            btn_verpedidos.TabIndex = 0;
            btn_verpedidos.Text = "Ver pedidos";
            btn_verpedidos.UseVisualStyleBackColor = false;
            btn_verpedidos.Click += btn_verpedidos_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Peru;
            btn_salir.FlatStyle = FlatStyle.Popup;
            btn_salir.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir.Location = new Point(85, 214);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(133, 38);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_verpedidos);
            groupBox1.Controls.Add(btn_salir);
            groupBox1.Location = new Point(540, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 412);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // CocinaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LogoDelizia;
            Controls.Add(groupBox1);
            Name = "CocinaMenu";
            Size = new Size(900, 600);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_verpedidos;
        private Button btn_salir;
        private GroupBox groupBox1;
    }
}
