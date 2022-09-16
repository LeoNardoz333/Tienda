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
    public partial class FrmPrincipal : Form
    {
        ManejadorTienda mt;
        public static EntidadesTienda tienda = new EntidadesTienda(0,"","",0);
        int columna, fila;
        public FrmPrincipal()
        {
            InitializeComponent();
            mt = new ManejadorTienda();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Actualizar()
        {
            mt.Mostrar(dtgProductos, txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
            fila = e.RowIndex;
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tienda.idProducto = int.Parse(dtgProductos.Rows[fila].Cells[0].Value.ToString());
            tienda.Nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            tienda.Descripcion = tienda.Nombre = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            tienda.Precio = int.Parse(dtgProductos.Rows[fila].Cells[3].Value.ToString());
            switch (columna)
            {
                case 4:
                    {
                        FrmProductos p = new FrmProductos();
                        p.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    } break;
                case 5:
                    {
                        mt.Borrar(tienda);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tienda.idProducto = -1;
            FrmProductos p = new FrmProductos();
            p.ShowDialog();
            Actualizar();
        }
    }
}
