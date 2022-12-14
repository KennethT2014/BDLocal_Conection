using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLocal_Conection.Data
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadExistente { get; set; }
        public int Precio { get; set; }
        public string estado { get; set; }
    }
}
