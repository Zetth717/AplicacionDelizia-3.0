using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LLogin
    {
        public string testing()
        {
            return "";
        }
        public Funcionario check_usuario(string cedula_ingresada, string contrasena_ingresada) {
            Funcionario sesion_actual = new Funcionario();
            int salida = -1;

            // hacer la consulta, devuelve una lista con los datos del usuario
            DLogin dlogin = new DLogin();
            List<string> datos_usuario = dlogin.get_funcionario(cedula_ingresada);

            // guarda los datos del usuario en la clase usuario
            sesion_actual.cedula = datos_usuario[0];
            sesion_actual.contrasena = datos_usuario[5];
            sesion_actual.activo = datos_usuario[7];

            if (sesion_actual.activo == "Si" && cedula_ingresada == sesion_actual.cedula && contrasena_ingresada == sesion_actual.contrasena)
            {
                // elimina la contraseña para proporcionar más seguridad
                sesion_actual.contrasena = "";

                sesion_actual.nombre = datos_usuario[1];
                sesion_actual.apellido = datos_usuario[2];
                sesion_actual.telefono = datos_usuario[3];
                sesion_actual.correo = datos_usuario[4];
                sesion_actual.direccion = datos_usuario[6];
                sesion_actual.rol = int.Parse(datos_usuario[8]);

                return sesion_actual;
            }
            else {
                return null;
            }
        }

        public void registrar_log(Funcionario sesion_actual) {
            DateTime dateTime = DateTime.Now;
            string fecha = DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            string hora = TimeOnly.FromDateTime(DateTime.Now).ToString("HH:mm:ss");
            string funcionario = sesion_actual.cedula;
            string equipo = Environment.MachineName;

            DLogin dlogin = new DLogin();
            dlogin.nuevo_log(fecha, hora, funcionario, equipo);
        }
    }
}
