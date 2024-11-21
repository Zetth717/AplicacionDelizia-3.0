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
    public partial class CocinaMenu : UserControl
    {
        Ventana padre;
        Funcionario user;
        MinimizarCerrar barraSuperior;
        public CocinaMenu(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
            // Instanciar y configurar la barra
            barraSuperior = new MinimizarCerrar();
            barraSuperior.Dock = DockStyle.Top; // O usar: barraSuperior.Location = new Point(0, 0);
            barraSuperior.Width = this.Width; // Asegúrate de ajustar al tamaño del formulario
            this.Controls.Add(barraSuperior);
            // Eventos de la barra
            barraSuperior.BotonCerrarClick += BarraSuperior_BotonCerrarClick;
            barraSuperior.BotonMinimizarClick += BarraSuperior_BotonMinimizarClick;
        }

        // Evento para cerrar la aplicación
        private void BarraSuperior_BotonCerrarClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento para minimizar la ventana principal
        private void BarraSuperior_BotonMinimizarClick(object sender, EventArgs e)
        {
            padre.WindowState = FormWindowState.Minimized;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new Login(padre));
        }

        private void btn_verpedidos_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new CocinaPedidos(padre, user));
        }
    }
}
