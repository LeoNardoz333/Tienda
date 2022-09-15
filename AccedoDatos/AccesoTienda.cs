using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccedoDatos
{
    public class AccesoTienda : IEntidades
    {
        Base b = new Base("localhost","root","","producto");
        public void Borrar(dynamic Entidad)
        {
            
        }

        public void Guardar(dynamic Entidad)
        {
            
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showproductos('%{0}%')", filtro), "producto");
        }
    }
}
