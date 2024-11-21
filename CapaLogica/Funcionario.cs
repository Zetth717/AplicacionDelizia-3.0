using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Funcionario
    {
        public string cedula = "";
        public string nombre = "";
        public string apellido = "";
        public string telefono = "";

        // unicamente para el login
        public string correo = "";
        public string contrasena = "";

        public string direccion = "";
        public string activo = "No";

        public int rol = 0;
    }
}
