using CapaDatos;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LRecepcion
    {
        public List<Producto> obtener_productos()
        {
            List<Producto> productos = new List<Producto>();
            DRecepcion drecepcion = new DRecepcion();
            List<List<String>> lista_string = drecepcion.obtener_productos();

            foreach (List<String> producto_string in lista_string)
            {
                Producto producto = new Producto();
                producto.id = int.Parse(producto_string[0]);
                producto.nombre = producto_string[1];
                producto.precio = double.Parse(producto_string[2]);
                producto.tipo = int.Parse(producto_string[3]);

                productos.Add(producto);
            }
            return productos;
        }

        public void insertar_cliente(Cliente cliente)
        {
            string consulta = "INSERT INTO clientes (Nombre, Apellido, Telefono, Direccion) VALUES ('" + cliente.nombre + "', '" + cliente.apellido + "', '" + cliente.telefono + "', '" + cliente.direccion + "')";

            DRecepcion drecepcion = new DRecepcion();
            drecepcion.insertar_cliente(consulta);
        }

        public void insertar_pedido(Pedido pedido)
        {
            string consulta = "INSERT INTO pedidos (Fecha, Hora, Estado, Precio, Cliente) VALUES ('" + pedido.fecha + "', '" + pedido.hora + "', '" + pedido.estado + "', '" + pedido.precio + "', '" + pedido.cliente + "')";
            DRecepcion drecepcion = new DRecepcion();
            drecepcion.insertar_pedido(consulta);
        }

        public int obtener_id_cliente(Cliente cliente)
        {
            DRecepcion drecepcion = new DRecepcion();
            int id_cliente = drecepcion.obtener_id_cliente(cliente.nombre, cliente.apellido);
            return id_cliente;
        }
        public int obtener_id_pedido(Pedido pedido)
        {
            DRecepcion drecepcion = new DRecepcion();
            int id_cliente = drecepcion.obtener_id_pedido(pedido.fecha, pedido.hora);
            return id_cliente;
        }

        public void insertar_pedido_producto(int id_pedido, int id_producto, int cantidad)
        {
            DRecepcion dRecepcion = new DRecepcion();
            dRecepcion.insertar_producto(id_pedido, id_producto, cantidad);
        }

        public void insertar_actualizacion_pedido(string funcionario, int pedido, string hora)
        {
            DRecepcion dRecepcion = new DRecepcion();
            dRecepcion.insertar_actualizacion_pedido(funcionario, pedido, hora);
        }

        public void crear_ticket(string fecha, string hora, int pedido)
        {
            string pago = "CONTADO";
            DRecepcion dRecepcion = new DRecepcion();
            dRecepcion.crear_ticket(fecha, hora, pedido, pago);
        }
    }
}
