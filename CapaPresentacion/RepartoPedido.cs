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
    public partial class RepartoPedido : UserControl
    {
        Pedido pedido;
        RepartoSeleccion rs;
        public RepartoPedido(RepartoSeleccion rs, Pedido pedido)
        {
            InitializeComponent();
            this.rs = rs;
            this.pedido = pedido;

            label1.Text = "" + pedido.id;
            label2.Text = pedido.nombre_cliente;
            label3.Text = pedido.direccion;
            label4.Text = pedido.telefono;
            lbl_Precio.Text = "$" + pedido.precio.ToString("F2");
        }

        private void btn_cambiar_estado_Click(object sender, EventArgs e)
        {
            LReparto lreparto = new LReparto();
            lreparto.tomar_pedido(rs.user.cedula, pedido.id);

            rs.actualizar_pantalla();
        }
    }
}
