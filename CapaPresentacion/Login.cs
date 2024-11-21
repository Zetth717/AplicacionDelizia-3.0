using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CapaPresentacion
{
    public partial class Login : UserControl
    {
        Ventana padre;
        MinimizarCerrar barraSuperior;
        public Login(Ventana padre)
        {
            InitializeComponent();
            this.padre = padre;
            // Instanciar y configurar la barra
            barraSuperior = new MinimizarCerrar();
            barraSuperior.Dock = DockStyle.Top; // O usar: barraSuperior.Location = new Point(0, 0);
            barraSuperior.Width = this.Width; // Asegúrate de ajustar al tamaño del formulario
            this.Controls.Add(barraSuperior);
            // Eventos de la barra
            barraSuperior.BotonCerrarClick += BarraSuperior_BotonCerrarClick;
            barraSuperior.BotonMinimizarClick += BarraSuperior_BotonMinimizarClick;
        }

        // Evento para cerrar la aplicación
        private void BarraSuperior_BotonCerrarClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento para minimizar la ventana principal
        private void BarraSuperior_BotonMinimizarClick(object sender, EventArgs e)
        {
            padre.WindowState = FormWindowState.Minimized;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            int rol_usuario;

            // obtenemos los datos del inicio
            string cedula_ingresada = txt_cedula.Text;
            string contrasena_ingresada = txt_contrasena.Text;

            LLogin llogin = new LLogin();
            
            // MessageBox.Show("", llogin.testing());

            // obtenemos los datos del usuario que se loguea
            Funcionario sesion_actual = llogin.check_usuario(cedula_ingresada, contrasena_ingresada);

            if (sesion_actual != null) // si no devuelve null obtiene el rol del usuario
            {
                rol_usuario = sesion_actual.rol;
            }
            else // si devuelve null establece rol a -1 y da error
            {
                rol_usuario = -1;
            }

            switch (rol_usuario)
            {
                case 1:
                    this.Dispose(); // elimina el login de la memoria
                    padre.Controls.Remove(this); // elimina visualmente el login

                    llogin.registrar_log(sesion_actual); // registra el inicio de sesion
                    padre.Controls.Add(new RecepcionMenu(padre, sesion_actual)); // da acceso a la app de recepcion
                    break;
                case 2:
                    this.Dispose(); // elimina el login de la memoria
                    padre.Controls.Remove(this); // elimina visualmente el login

                    llogin.registrar_log(sesion_actual); // registra el inicio de sesion
                    padre.Controls.Add(new CocinaMenu(padre, sesion_actual)); // da acceso a la app de cocina
                    break;
                case 3:
                    this.Dispose(); // elimina el login de la memoria
                    padre.Controls.Remove(this); // elimina visualmente el login

                    llogin.registrar_log(sesion_actual); // registra el inicio de sesion
                    padre.Controls.Add(new RepartoMenu(padre, sesion_actual)); // da acceso a la app de reparto
                    break;
                case 4:
                    this.Dispose(); // elimina el login de la memoria
                    padre.Controls.Remove(this); // elimina visualmente el login

                    llogin.registrar_log(sesion_actual); // registra el inicio de sesion
                    padre.Controls.Add(new AdministracionUsuariosAgregar(padre, sesion_actual)); // da acceso a la app de reparto
                    break;
                default:
                    // muestra un mensaje de error
                    break;
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_cedula.Text = string.Empty; // borra el texto en cedula
            txt_contrasena.Text = string.Empty; // borra el texto en contraseña
        }
    }
}
