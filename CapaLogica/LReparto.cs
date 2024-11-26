using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LReparto
    {

        public List<Pedido> obtener_pedidos_tomados(string cedula) {
            string consulta = "SELECT pedidos.Id, clientes.Direccion, clientes.Nombre, clientes.Telefono FROM pedidos INNER JOIN clientes ON clientes.Id = pedidos.Cliente WHERE pedidos.Estado = 2 AND pedidos.Repartidor = " + cedula;
            Conexion c = new Conexion();
            List<List<String>> pedidos_string = c.consultar(consulta);
            List<Pedido> pedidos = new List<Pedido>();
            foreach (List<String> pedido_string in pedidos_string)
            {
                Pedido pedido = new Pedido();
                pedido.id = int.Parse(pedido_string[0]);
                pedido.direccion = pedido_string[1];
                pedido.nombre_cliente = pedido_string[2];
                pedido.telefono = pedido_string[3];
                pedidos.Add(pedido);
            }
            return pedidos;
        }

        public List<Pedido> obtener_pedidos_libres()
        {
            string consulta = "SELECT pedidos.Id, clientes.Direccion, clientes.Nombre, clientes.Telefono FROM pedidos INNER JOIN clientes ON clientes.Id = pedidos.Cliente WHERE pedidos.Estado = 2 AND pedidos.Repartidor IS NULL";
            Conexion c = new Conexion();
            List<List<String>> pedidos_string = c.consultar(consulta);
            List<Pedido> pedidos = new List<Pedido>();
            foreach (List<String> pedido_string in pedidos_string)
            {
                Pedido pedido = new Pedido();
                pedido.id = int.Parse(pedido_string[0]);
                pedido.direccion = pedido_string[1];
                pedido.nombre_cliente = pedido_string[2];
                pedido.telefono = pedido_string[3];
                pedidos.Add(pedido);
            }
            return pedidos;
        }

        public void tomar_pedido(string cedula, int pedido)
        {
            string consulta = "UPDATE pedidos SET Repartidor=" + cedula + " WHERE Id=" + pedido;
            Conexion c = new Conexion();
            c.modificar(consulta);
        }

        public void cambiar_estado_producto(int pedido)
        {
            string consulta = "UPDATE pedidos SET Estado=3 WHERE Id=" + pedido;
            Conexion c = new Conexion();
            c.modificar(consulta);
        }
    }
}
