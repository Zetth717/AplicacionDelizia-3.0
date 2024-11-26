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
    public partial class RepartoPedidoTomado : UserControl
    {
        Pedido pedido;
        RepartoTomados rt;
        public RepartoPedidoTomado(RepartoTomados rt, Pedido pedido)
        {
            InitializeComponent();
            this.rt = rt;
            this.pedido = pedido;

            label1.Text = "" + pedido.id;
            label2.Text = pedido.nombre_cliente;
            label3.Text = pedido.direccion;
            label4.Text = pedido.telefono;
        }

        private void btn_cambiar_estado_Click(object sender, EventArgs e)
        {
            LReparto lreparto = new LReparto();
            lreparto.cambiar_estado_producto(pedido.id);

            rt.actualizar_pantalla();
        }
    }
}
