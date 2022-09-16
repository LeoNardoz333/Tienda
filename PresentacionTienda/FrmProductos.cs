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
            if(FrmPrincipal.tienda.idProducto>0)
            {
                txtNombre.Text = FrmPrincipal.tienda.Nombre;
                txtDescripcion.Text = FrmPrincipal.tienda.Descripcion;
                txtPrecio.Text = FrmPrincipal.tienda.Precio.ToString();
            }
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
