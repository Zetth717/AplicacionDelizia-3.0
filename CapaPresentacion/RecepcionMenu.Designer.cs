namespace CapaPresentacion
{
    partial class RecepcionMenu
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
            btn_nuevopedido = new Button();
            btn_salir = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_nuevopedido
            // 
            btn_nuevopedido.BackColor = Color.Olive;
            btn_nuevopedido.FlatStyle = FlatStyle.Popup;
            btn_nuevopedido.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nuevopedido.Location = new Point(83, 147);
            btn_nuevopedido.Name = "btn_nuevopedido";
            btn_nuevopedido.Size = new Size(133, 38);
            btn_nuevopedido.TabIndex = 0;
            btn_nuevopedido.Text = "Nuevo pedido";
            btn_nuevopedido.UseVisualStyleBackColor = false;
            btn_nuevopedido.Click += btn_nuevopedido_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Firebrick;
            btn_salir.FlatStyle = FlatStyle.Popup;
            btn_salir.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir.Location = new Point(83, 204);
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_nuevopedido);
            groupBox1.Controls.Add(btn_salir);
            groupBox1.Location = new Point(540, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 412);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(200, 62);
            label1.TabIndex = 3;
            label1.Text = "Recepción";
            // 
            // RecepcionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LogoDelizia;
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Name = "RecepcionMenu";
            Size = new Size(900, 600);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_nuevopedido;
        private Button btn_salir;
        private GroupBox groupBox1;
        private Label label1;
    }
}
