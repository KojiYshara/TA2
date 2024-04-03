using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA2.Entities;

namespace TA2.Controllers
{
    internal class ProductoCon
    {
        private Producto[] productos = new Producto[100];
        private int cont = 0;

        public Producto[] ListarTodo()
        {
            return productos;
        }

        public void Registrar (Producto producto)
        {
            productos[cont] = producto;
            cont++;
        }

        public void Eliminar (String Codigo)
        {
            int pos = Array.FindIndex(productos, producto => producto.Codigo.Equals(Codigo));
            for (int i = 0; i < cont; i++)
            {
                if (i >= pos)
                {
                    productos[i] = productos[i + 1];

                }
            }
            cont--;
        }

    }
}
