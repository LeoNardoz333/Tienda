using AccedoDatos;
using Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorTienda : IManejador
    {
        AccesoTienda t = new AccesoTienda();
        Graficos g = new Graficos();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Estás seguro de borrar: {0}",
                Entidad.Nombre), "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                t.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            t.Guardar(Entidad);
            g.Mensaje("Se guardó correctamente","¡ATENCIÓN!",MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = t.Mostrar(filtro).Tables["producto"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
