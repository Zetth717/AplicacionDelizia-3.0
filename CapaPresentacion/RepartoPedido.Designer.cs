namespace CapaPresentacion
{
    partial class RepartoPedido
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_cambiar_estado = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label3.Location = new Point(9, 93);
            label3.Name = "label3";
            label3.Size = new Size(179, 62);
            label3.TabIndex = 7;
            label3.Text = "Direccion Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label2.Location = new Point(9, 47);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 6;
            label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 5;
            label1.Text = "Id Pedido";
            // 
            // btn_cambiar_estado
            // 
            btn_cambiar_estado.BackColor = Color.Peru;
            btn_cambiar_estado.FlatStyle = FlatStyle.Popup;
            btn_cambiar_estado.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cambiar_estado.ForeColor = Color.Black;
            btn_cambiar_estado.Location = new Point(9, 182);
            btn_cambiar_estado.Name = "btn_cambiar_estado";
            btn_cambiar_estado.Size = new Size(179, 46);
            btn_cambiar_estado.TabIndex = 4;
            btn_cambiar_estado.Text = "TOMAR";
            btn_cambiar_estado.UseVisualStyleBackColor = false;
            btn_cambiar_estado.Click += btn_cambiar_estado_Click;
            // 
            // RepartoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_cambiar_estado);
            Name = "RepartoPedido";
            Size = new Size(209, 231);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_cambiar_estado;
    }
}
