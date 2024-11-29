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
    public partial class RecepcionProducto : UserControl
    {
        public Producto producto;
        public RecepcionProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            actualizar_informacion();

            string ruta_imagen = "C:\\Users\\crist\\OneDrive\\Escritorio\\delizia_app_funcional\\aplicacion-delizia\\AplicacionDelizia\\Imagenes\\" + producto.id + ".png";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = ruta_imagen;
        }

        public void actualizar_informacion()
        {
            lbl_nombre.Text = producto.nombre;
            lbl_cantidad.Text = producto.cantidad.ToString();
            lbl_precio.Text = "$" + producto.precio;
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            producto.cantidad += 1;
            lbl_cantidad.Text = producto.cantidad.ToString();
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (producto.cantidad >= 1)
            {
                producto.cantidad -= 1;
                lbl_cantidad.Text = producto.cantidad.ToString();
            }
        }
    }
}
