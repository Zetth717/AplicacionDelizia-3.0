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
    public partial class MinimizarCerrar : UserControl
    {
        private bool arrastrando = false;
        private Point puntoInicial;
        public event EventHandler BotonCerrarClick;
        public event EventHandler BotonMinimizarClick;
        public MinimizarCerrar()
        {
            InitializeComponent();
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            BotonCerrarClick?.Invoke(this, EventArgs.Empty);
        }

        public void btnMinimizar_Click(object sender, EventArgs e)
        {
            BotonMinimizarClick?.Invoke(this, EventArgs.Empty);
        }

        private void MinimizarCerrar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = true;
                puntoInicial = e.Location;
            }
        }

        private void MinimizarCerrar_MouseMove(object sender, MouseEventArgs e)
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

        private void MinimizarCerrar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = false;
            }
        }
    }
}
