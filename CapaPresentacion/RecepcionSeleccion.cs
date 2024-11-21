using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class RecepcionSeleccion : UserControl
    {
        Ventana padre;
        Funcionario user;
        List<Producto> productos;
        List<RecepcionProducto> productos_graficos;
        public RecepcionSeleccion(Ventana padre, Funcionario user, List<Producto> productos)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
            MinimizarCerrar barraSuperior;

            // obtener productos
            if (productos != null) // si le pasamos la lista de productos la iguala
            {
                this.productos = productos;
            }
            else // si no la obtiene
            {
                LRecepcion lrecepcion = new LRecepcion();
                productos = lrecepcion.obtener_productos();
            }

            // mostrar productos
            mostrar_productos(productos);
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

        private void mostrar_productos(List<Producto> productos)
        {
            productos_graficos = new List<RecepcionProducto>();

            int x = 5;
            int y = 20;
            int contador = 0;
            foreach (Producto producto in productos)
            {
                RecepcionProducto rp = new RecepcionProducto(producto);
                if (contador%3 == 0){
                    if (contador == 0){
                        x = 5;
                        y = 20;
                    }
                    else
                    {
                        x = 5;
                        y += 5 + rp.Height;
                    }
                }
                else
                {
                    x += 5 + rp.Width;
                }
                rp.Location = new Point(x, y);
                contador++;
                productos_graficos.Add(rp);
            }

            foreach(RecepcionProducto producto in productos_graficos)
            {
                this.pan_productos.Controls.Add(producto);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            List<Producto> lista_productos = new List<Producto>();
            foreach (RecepcionProducto rp in productos_graficos)
            {
                lista_productos.Add(rp.producto);
            }
            padre.Controls.Add(new RecepcionConfirmacion(padre, user, lista_productos));
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new RecepcionMenu(padre, user));
        }
    }
}
