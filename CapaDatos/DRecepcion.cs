using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRecepcion
    {
        public List<List<String>> obtener_productos()
        {
            string consulta = "SELECT * FROM productos";
            Conexion conexion = new Conexion();
            List<List<String>> resultado = conexion.consultar(consulta);
            return resultado;
        }

        public void insertar_cliente(string consulta) {
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }

        public void insertar_pedido(string consulta)
        {
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }

        public int obtener_id_cliente(string nombre, string apellido) {
            // genera la consulta
            string consulta = "SELECT Id FROM clientes WHERE Nombre='" + nombre + "' AND Apellido='" + apellido + "' ORDER BY Id DESC LIMIT 1";
            Conexion conexion = new Conexion();
            // obtiene una lista de listas con los resultados
            List<List<String>> resultado = conexion.consultar(consulta);
            // obtiene el primer resultado de esa lista
            int id = int.Parse(resultado[0][0]);
            return id;
        }

        public int obtener_id_pedido(string fecha, string hora)
        {
            // genera la consulta
            string consulta = "SELECT Id FROM pedidos WHERE Fecha='" + fecha + "' AND Hora='" + hora + "'";
            Conexion conexion = new Conexion();
            // obtiene una lista de listas con los resultados
            List<List<String>> resultado = conexion.consultar(consulta);
            // obtiene el primer resultado de esa lista
            int id = int.Parse(resultado[0][0]);
            return id;
        }

        public void insertar_producto(int id_pedido, int id_producto, int cantidad)
        {
            string consulta = "INSERT INTO pedidosproductos (Pedido, Producto, Cantidad) VALUES ('"+id_pedido+"', '"+id_producto+"', '"+cantidad+"')";
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }

        public void insertar_actualizacion_pedido(string funcionario, int pedido, string hora)
        {
            string consulta = "INSERT INTO funcionariospedidos (Funcionario, Pedido, Hora) VALUES ('" + funcionario + "', '" + pedido + "', '" + hora + "')";
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }

        public void crear_ticket(string fecha, string hora, int pedido, string pago)
        {
            string consulta = "INSERT INTO tickets (Fecha, Hora, Pedido, Pago) VALUES ('" + fecha + "', '" + hora + "', '" + pedido + "', '" + pago + "')";
            DRecepcion dRecepcion = new DRecepcion();
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }
    }
}
