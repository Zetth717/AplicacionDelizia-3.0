using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LCocina
    {

        public List<Pedido> obtener_datos_pedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            string consulta = "SELECT Id, Estado FROM pedidos WHERE Estado = 1";

            Conexion conexion = new Conexion();

            List<List<String>> pedidos_string = conexion.consultar(consulta);

            foreach (List<String> pedido_string in pedidos_string)
            {
                Pedido pedido = new Pedido();
                pedido.id = int.Parse(pedido_string[0]);
                pedido.estado = int.Parse(pedido_string[1]);
                pedidos.Add(pedido);
            }

            return pedidos;
        }
        public List<Producto> obtener_productos_pedido(Pedido pedido)
        {
            string consulta = "SELECT productos.Nombre, pedidosproductos.Cantidad FROM productos INNER JOIN pedidosproductos ON productos.Id = pedidosproductos.Producto WHERE pedidosproductos.Pedido = '" + pedido.id + "'";
            DCocina dcocina = new DCocina();
            List<List<String>> productos_string = dcocina.obtener_productos(consulta);

            List<Producto> productos = new List<Producto>();
            foreach (List<String> producto_string in productos_string)
            {
                Producto producto = new Producto();
                producto.nombre = producto_string[0];
                producto.cantidad = int.Parse(producto_string[1]);
                productos.Add(producto);
            }
            return productos;
        }

        public void cambiar_estado_producto(int pedido)
        {
            string consulta = "UPDATE pedidos SET Estado=2 WHERE Id=" + pedido;
            Conexion c = new Conexion();
            c.modificar(consulta);
        }
    }
}
