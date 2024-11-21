using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAdministracion
    {

        public void crear_usuario(string consulta)
        {
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }
        public void crear_telefono(string consulta)
        {
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }
        public void DarAltaUsuario(string cedula)
        {
            Conexion conexion = new Conexion();
            string consulta = "UPDATE `funcionarios` SET `Activo` = 'SI' WHERE `Cedula` = '" + cedula + "'";
            conexion.modificar(consulta);
        }

        public void DarBajaUsuario(string cedula)
        {
            Conexion conexion = new Conexion();
            string consulta = "UPDATE `funcionarios` SET `Activo` = 'NO' WHERE `Cedula` = '" + cedula + "'";
            conexion.modificar(consulta);
        }
    }
}
