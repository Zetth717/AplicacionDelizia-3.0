using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCocina
    {

        public List<List<String>> obtener_productos(string consulta)
        {
            Conexion conexion = new Conexion();
            return conexion.consultar(consulta);
        }
    }
}
