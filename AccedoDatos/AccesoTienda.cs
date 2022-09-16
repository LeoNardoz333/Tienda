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
        Base b = new Base("localhost","root","","tienda");
        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("call deleteproductos({0})",Entidad.idProducto));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertarproductos({0},'{1}','{2}',{3})",
                Entidad.idProducto,Entidad.Nombre,Entidad.Descripcion,Entidad.Precio));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showproductos('%{0}%')", filtro), "producto");
        }
    }
}
