using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Producto
    {
        public int id = 0;
        public string nombre = "";
        public double precio = 0;
        public int tipo = 0;

        // en caso de pertenecer a un pedido
        public int cantidad = 0;
    }
}