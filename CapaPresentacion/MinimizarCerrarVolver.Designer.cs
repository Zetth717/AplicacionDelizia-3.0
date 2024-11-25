namespace CapaPresentacion
{
    partial class MinimizarCerrarVolver
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.Cerrar;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(869, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackgroundImage = Properties.Resources.Minimizar;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Location = new Point(833, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.Volver1;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Location = new Point(2, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(30, 30);
            btnVolver.TabIndex = 2;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // MinimizarCerrarVolver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnVolver);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Cursor = Cursors.NoMove2D;
            Name = "MinimizarCerrarVolver";
            Size = new Size(900, 30);
            MouseDown += MinimizarCerrarVolver_MouseDown;
            MouseMove += MinimizarCerrarVolver_MouseMove;
            MouseUp += MinimizarCerrarVolver_MouseUp;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnVolver;
    }
}
