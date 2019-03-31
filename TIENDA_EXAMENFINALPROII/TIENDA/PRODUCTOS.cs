using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_EXAMENFINALPROII.TIENDA
{
    public class PRODUCTOS : CLIENTE
    {
        public string TipodeProducto { get; set; }

        public int TiempodeCompra { get; set; }

        public int TiempoEstimado { get; set; }
    }
}
