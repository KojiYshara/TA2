using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2.Entities
{
    class Producto
    {
        public Producto() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
