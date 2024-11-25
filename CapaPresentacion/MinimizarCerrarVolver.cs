using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MinimizarCerrarVolver : UserControl
    {
        Ventana padre;
        Funcionario user;
        private bool arrastrando = false;
        private Point puntoInicial;
        public event EventHandler BotonCerrarClick;
        public event EventHandler BotonMinimizarClick;
        public event EventHandler BotonVolverClick;
        public MinimizarCerrarVolver()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            BotonCerrarClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            BotonMinimizarClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            BotonVolverClick?.Invoke(this, EventArgs.Empty);
         
        }

        private void MinimizarCerrarVolver_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = true;
                puntoInicial = e.Location;
            }
        }

        private void MinimizarCerrarVolver_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                Form formulario = this.FindForm();

                if (formulario != null)
                {
                    formulario.Location = new Point(
                        formulario.Location.X + e.X - puntoInicial.X,
                        formulario.Location.Y + e.Y - puntoInicial.Y
                    );
                }
            }
        }

        private void MinimizarCerrarVolver_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = false;
            }
        }
    }
}
