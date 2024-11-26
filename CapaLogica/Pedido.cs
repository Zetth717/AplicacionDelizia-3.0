using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Pedido
    {
        public int id = -1;
        public string fecha = "";
        public string hora = "";
        public int estado = 0;
        public double precio = 0;
        public int cliente = 0;
        public List<Producto> productos = new List<Producto>();
        public string direccion = "";
        public string nombre_cliente = "";
        public string telefono = "";
    }
}
