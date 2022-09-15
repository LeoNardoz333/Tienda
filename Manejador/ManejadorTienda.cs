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
            
        }

        public void Guardar(dynamic Entidad)
        {
            
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = t.Mostrar(filtro).Tables["pais"];
            tabla.Columns.Insert(3, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
