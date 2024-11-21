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
    public partial class CocinaPedido : UserControl
    {
        Pedido pedido;
        List<CocinaPedidoProducto> productos_graficos;
        CocinaPedidos cp;
        public CocinaPedido(Pedido pedido, CocinaPedidos cp)
        {
            InitializeComponent();
            this.pedido = pedido;

            lbl_id.Text = "" + pedido.id;

            LCocina lcocina = new LCocina();

            // obtener la información del pedido
            //pedido = lcocina.obtener_datos_pedido(pedido);

            // obtener los productos
            pedido.productos = lcocina.obtener_productos_pedido(pedido);

            // genera los productos de manera gráfica
            productos_graficos = obtener_productos_graficos(pedido.productos);
            // muestra los productos
            mostrar_productos_graficos(productos_graficos);
            this.cp = cp;
        }

        public List<CocinaPedidoProducto> obtener_productos_graficos(List<Producto> productos)
        {
            List<CocinaPedidoProducto> salida = new List<CocinaPedidoProducto>();
            int x = 0;
            int y = 0;
            foreach (Producto p in productos)
            {
                CocinaPedidoProducto producto_grafico = new CocinaPedidoProducto(p);
                producto_grafico.Location = new Point(x, y);
                salida.Add(producto_grafico);
                y += 1 + producto_grafico.Height;
            }
            return salida;
        }
        public void mostrar_productos_graficos(List<CocinaPedidoProducto> productos)
        {
            foreach (CocinaPedidoProducto p in productos)
            {
                pan_productos.Controls.Add((p));
            }
        }

        private void btn_cambiar_estado_Click(object sender, EventArgs e)
        {
            //
            LCocina lcocina = new LCocina();
            lcocina.cambiar_estado_producto(pedido.id);

            cp.actualizar_pantalla();
        }

    }
}
