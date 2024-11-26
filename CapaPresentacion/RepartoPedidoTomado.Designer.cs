namespace CapaPresentacion
{
    partial class RepartoPedidoTomado
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
            btn_cambiar_estado = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pan_productos = new Panel();
            label4 = new Label();
            pan_productos.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cambiar_estado
            // 
            btn_cambiar_estado.BackColor = Color.Olive;
            btn_cambiar_estado.FlatStyle = FlatStyle.Popup;
            btn_cambiar_estado.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cambiar_estado.Location = new Point(48, 174);
            btn_cambiar_estado.Name = "btn_cambiar_estado";
            btn_cambiar_estado.Size = new Size(107, 36);
            btn_cambiar_estado.TabIndex = 0;
            btn_cambiar_estado.Text = "ESTADO";
            btn_cambiar_estado.UseVisualStyleBackColor = false;
            btn_cambiar_estado.Click += btn_cambiar_estado_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.PeachPuff;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label1.Location = new Point(8, 6);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 1;
            label1.Text = "Id Pedido";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 6);
            label2.Name = "label2";
            label2.Size = new Size(138, 30);
            label2.TabIndex = 2;
            label2.Text = "Nombre Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label3.Location = new Point(13, 38);
            label3.Name = "label3";
            label3.Size = new Size(150, 30);
            label3.TabIndex = 3;
            label3.Text = "Direccion Cliente";
            // 
            // pan_productos
            // 
            pan_productos.BackColor = Color.PeachPuff;
            pan_productos.BorderStyle = BorderStyle.FixedSingle;
            pan_productos.Controls.Add(label4);
            pan_productos.Controls.Add(label3);
            pan_productos.Controls.Add(label2);
            pan_productos.Location = new Point(8, 39);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(194, 113);
            pan_productos.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label4.Location = new Point(13, 70);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 4;
            label4.Text = "Telefono";
            // 
            // RepartoPedidoTomado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            Controls.Add(pan_productos);
            Controls.Add(label1);
            Controls.Add(btn_cambiar_estado);
            Name = "RepartoPedidoTomado";
            Size = new Size(209, 231);
            pan_productos.ResumeLayout(false);
            pan_productos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cambiar_estado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pan_productos;
        private Label label4;
    }
}
