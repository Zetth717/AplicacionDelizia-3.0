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
    public partial class RepartoSeleccion : UserControl
    {
        public Funcionario user;
        Ventana padre;
        List<Pedido> pedidos;
        List<RepartoPedido> pedidos_graficos = new List<RepartoPedido>();
        MinimizarCerrar barraSuperior;
        public RepartoSeleccion(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            int x = (padre.Width - this.Width) / 2;
            int y = (padre.Height - this.Height) / 2;

            Location = new Point(x, y);

            pedidos = new List<Pedido>();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_libres();

            mostrar_pedidos(pedidos);
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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new RepartoMenu(padre, user));
        }

        // copia

        private void mostrar_pedidos(List<Pedido> pedidos)
        {
            int x = 5;
            int y = 20;
            int contador = 0;
            foreach (Pedido pedido in pedidos)
            {
                RepartoPedido cp = new RepartoPedido(this, pedido);
                if (contador % 5 == 0)
                {
                    if (contador == 0)
                    {
                        x = 5;
                        y = 20;
                    }
                    else
                    {
                        x = 5;
                        y += 5 + cp.Height;
                    }
                }
                else
                {
                    x += 5 + cp.Width;
                }
                cp.Location = new Point(x, y);
                contador++;
                pedidos_graficos.Add(cp);
            }

            foreach (RepartoPedido pedido in pedidos_graficos)
            {
                this.pan_pedidos.Controls.Add(pedido);
            }
        }

        public void actualizar_pantalla()
        {
            pan_pedidos.Controls.Clear();

            pedidos.Clear();
            pedidos_graficos.Clear();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_libres();

            mostrar_pedidos(pedidos);
        }
    }
}
