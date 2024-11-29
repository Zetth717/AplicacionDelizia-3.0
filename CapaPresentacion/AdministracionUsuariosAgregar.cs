using CapaDatos;
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

namespace CapaPresentacion
{
    public partial class AdministracionUsuariosAgregar : UserControl
    {
        Funcionario user;
        Ventana padre;
        MinimizarCerrarVolver barraSuperior;
        public AdministracionUsuariosAgregar(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            // Instanciar y configurar la barra
            barraSuperior = new MinimizarCerrarVolver();
            barraSuperior.Dock = DockStyle.Top; // O usar: barraSuperior.Location = new Point(0, 0);
            barraSuperior.Width = this.Width; // Asegúrate de ajustar al tamaño del formulario
            this.Controls.Add(barraSuperior);
            // Eventos de la barra
            barraSuperior.BotonCerrarClick += BarraSuperior_BotonCerrarClick;
            barraSuperior.BotonMinimizarClick += BarraSuperior_BotonMinimizarClick;
            barraSuperior.BotonVolverClick += BarraSuperior_BotonVolverClick;


            LAdministracion la = new LAdministracion();
            List<Funcionario> funcionarios = la.obtener_funcionarios();

            foreach (Funcionario f in funcionarios)
            {
                listBoxUsuarios.Items.Add($"{f.nombre} - {f.apellido} - ({f.cedula})");
            }
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

        private void BarraSuperior_BotonVolverClick(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new Login(padre));
        }

        public Funcionario obtener_datos_funcionario()
        {
            Funcionario nuevo_usuario = new Funcionario();

            nuevo_usuario.cedula = txt_cedula.Text;
            nuevo_usuario.nombre = txt_nombre.Text;
            nuevo_usuario.apellido = txt_apellido.Text;
            nuevo_usuario.direccion = txt_direccion.Text;
            nuevo_usuario.telefono = txt_telefono.Text;
            nuevo_usuario.correo = txt_correo.Text;
            nuevo_usuario.contrasena = txt_contrasena.Text;
            nuevo_usuario.activo = "Si";
            // nuevo_usuario.rol = int.Parse(txt_rol.Text);
            nuevo_usuario.rol = int.Parse(menu_rol.Text);

            return nuevo_usuario;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que todos los campos estén completos
                if (string.IsNullOrWhiteSpace(txt_cedula.Text) ||
                    string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_apellido.Text) ||
                    string.IsNullOrWhiteSpace(txt_direccion.Text) ||
                    string.IsNullOrWhiteSpace(txt_telefono.Text) ||
                    string.IsNullOrWhiteSpace(txt_correo.Text) ||
                    string.IsNullOrWhiteSpace(txt_contrasena.Text) ||
                    string.IsNullOrWhiteSpace(menu_rol.Text) || menu_rol.Text == "0")
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LAdministracion ladministracion = new LAdministracion();

                Funcionario nuevo_usuario = obtener_datos_funcionario();
                ladministracion.insertar_usuario(nuevo_usuario);

                txt_cedula.Text = string.Empty;
                txt_nombre.Text = string.Empty;
                txt_apellido.Text = string.Empty;
                txt_direccion.Text = string.Empty;
                txt_telefono.Text = string.Empty;
                txt_correo.Text = string.Empty;
                txt_contrasena.Text = string.Empty;
                // txt_rol.Text = string.Empty;
                menu_rol.Text = "0";
                CargarUsuariosActivos();
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de errores inesperados
                MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            /*
            string cedula = textCedulaAlta.Text.Trim();
            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Por favor, ingresa una cédula válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LAdministracion logica = new LAdministracion();
            try
            {
                logica.DarAltaUsuario(cedula);
                MessageBox.Show("Usuario dado de alta exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCedulaAlta.Text = "";
                CargarUsuariosActivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja al usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            string cedula = textCedulaAlta.Text.Trim();
            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Por favor, ingresa una cédula válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LAdministracion logica = new LAdministracion();
            try
            {
                string estado = logica.ObtenerEstadoCedula(cedula);

                if (estado == null)
                {
                    MessageBox.Show("La cédula ingresada no existe en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (estado.Equals("Si", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El funcionario ya se encuentra activo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                logica.DarAltaUsuario(cedula);
                MessageBox.Show("Usuario dado de alta exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCedulaAlta.Text = "";
                CargarUsuariosActivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de alta al usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            

        private void CargarUsuariosActivos()
        {
           
            listBoxUsuarios.Items.Clear();
            LAdministracion logica = new LAdministracion();
            List<Funcionario> funcionarios = logica.obtener_funcionarios();
            foreach (Funcionario f in funcionarios)
            {
                listBoxUsuarios.Items.Add($"{f.nombre} - {f.apellido} - ({f.cedula})");
            }
        }

        
        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedIndex != -1)
            {
                string seleccion = listBoxUsuarios.SelectedItem.ToString();
                string cedulaSeleccionada = seleccion.Split('(').Last().Trim(')', ' ');
                LAdministracion logica = new LAdministracion();
                Funcionario usuarioSeleccionado = logica.obtener_funcionarios()
                    .FirstOrDefault(f => f.cedula == cedulaSeleccionada);

                if (usuarioSeleccionado != null)
                {
                    logica.DarBajaUsuario(usuarioSeleccionado.cedula);
                    MessageBox.Show("Usuario dado de baja exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuariosActivos();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para dar de baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    } 
}
