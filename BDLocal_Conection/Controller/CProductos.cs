using BDLocal_Conection.Clases;
using BDLocal_Conection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLocal_Conection.Controller
{
    public class CProductos
    {
        public static void SalvarProductos(string NombreProducto,
                                           int CantidadExistente,
                                           int Precio)
        {
            Producto producto = new Producto();
            producto.NombreProducto = NombreProducto;
            producto.CantidadExistente = CantidadExistente;
            producto.Precio = Precio;
            producto.estado = "Habilitado";

            DProducto.SalvarProducto(producto);
        }

        public static List<Producto> MostrarProductos()
        {
            return DProducto.SalvarProducto();
        }
    }
}
