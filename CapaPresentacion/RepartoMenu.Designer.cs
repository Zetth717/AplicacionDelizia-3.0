namespace CapaPresentacion
{
    partial class RepartoMenu
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
            btn_mis_pedidos = new Button();
            btn_tomar_pedidos = new Button();
            btn_salir = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_mis_pedidos
            // 
            btn_mis_pedidos.BackColor = Color.Olive;
            btn_mis_pedidos.FlatStyle = FlatStyle.Popup;
            btn_mis_pedidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btn_mis_pedidos.Location = new Point(84, 181);
            btn_mis_pedidos.Name = "btn_mis_pedidos";
            btn_mis_pedidos.Size = new Size(133, 38);
            btn_mis_pedidos.TabIndex = 0;
            btn_mis_pedidos.Text = "Mis pedidos";
            btn_mis_pedidos.UseVisualStyleBackColor = false;
            btn_mis_pedidos.Click += btn_mis_pedidos_Click;
            // 
            // btn_tomar_pedidos
            // 
            btn_tomar_pedidos.BackColor = Color.Olive;
            btn_tomar_pedidos.FlatStyle = FlatStyle.Popup;
            btn_tomar_pedidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btn_tomar_pedidos.Location = new Point(84, 129);
            btn_tomar_pedidos.Name = "btn_tomar_pedidos";
            btn_tomar_pedidos.Size = new Size(133, 38);
            btn_tomar_pedidos.TabIndex = 1;
            btn_tomar_pedidos.Text = "Tomar pedidos";
            btn_tomar_pedidos.UseVisualStyleBackColor = false;
            btn_tomar_pedidos.Click += btn_tomar_pedidos_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Firebrick;
            btn_salir.FlatStyle = FlatStyle.Popup;
            btn_salir.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btn_salir.Location = new Point(84, 233);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(133, 38);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_mis_pedidos);
            groupBox1.Controls.Add(btn_salir);
            groupBox1.Controls.Add(btn_tomar_pedidos);
            groupBox1.Location = new Point(540, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 412);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(66, 26);
            label1.Name = "label1";
            label1.Size = new Size(167, 62);
            label1.TabIndex = 3;
            label1.Text = "Reparto";
            // 
            // RepartoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LogoDelizia;
            Controls.Add(groupBox1);
            Name = "RepartoMenu";
            Size = new Size(900, 600);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_mis_pedidos;
        private Button btn_tomar_pedidos;
        private Button btn_salir;
        private GroupBox groupBox1;
        private Label label1;
    }
}
