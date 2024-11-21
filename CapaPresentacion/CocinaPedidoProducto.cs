using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class CocinaPedidoProducto : UserControl
    {
        Producto producto;
        public CocinaPedidoProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;

            lbl_detalles.Text = producto.nombre + "|" + producto.cantidad;
        }
    }
}
