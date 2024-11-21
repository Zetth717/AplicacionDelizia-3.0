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
    public partial class RecepcionConfirmacionProducto : UserControl
    {
        Producto producto;
        public RecepcionConfirmacionProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;

            lbl_contenido.Text = "Cantidad | Nombre del producto | Precio unitario | Precio Total";
            lbl_contenido.Text = producto.cantidad + " | " + producto.nombre + " | $" + producto.precio + " | $" + (producto.precio*producto.cantidad);
        }
        public Producto get_producto()
        {
            return producto;
        }
    }
}
