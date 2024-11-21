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
            SuspendLayout();
            // 
            // btn_cambiar_estado
            // 
            btn_cambiar_estado.BackColor = Color.Peru;
            btn_cambiar_estado.FlatStyle = FlatStyle.Popup;
            btn_cambiar_estado.Font = new Font("Segoe Print", 9F);
            btn_cambiar_estado.Location = new Point(9, 205);
            btn_cambiar_estado.Name = "btn_cambiar_estado";
            btn_cambiar_estado.Size = new Size(75, 23);
            btn_cambiar_estado.TabIndex = 0;
            btn_cambiar_estado.Text = "ESTADO";
            btn_cambiar_estado.UseVisualStyleBackColor = false;
            btn_cambiar_estado.Click += btn_cambiar_estado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F);
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 1;
            label1.Text = "Id Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F);
            label2.Location = new Point(9, 47);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F);
            label3.Location = new Point(9, 93);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 3;
            label3.Text = "Direccion Cliente";
            // 
            // RepartoPedidoTomado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_cambiar_estado);
            Name = "RepartoPedidoTomado";
            Size = new Size(209, 231);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cambiar_estado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
