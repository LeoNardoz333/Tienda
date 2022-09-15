using Entidades;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionTienda
{
    public partial class FrmProductos : Form
    {
        ManejadorTienda mt;
        public FrmProductos()
        {
            InitializeComponent();
            mt = new ManejadorTienda();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mt.Guardar(new EntidadesTienda(FrmPrincipal.tienda.idProducto,txtNombre.Text,txtDescripcion.Text
                ,double.Parse(txtPrecio.Text)));
            Close();
        }
    }
}
