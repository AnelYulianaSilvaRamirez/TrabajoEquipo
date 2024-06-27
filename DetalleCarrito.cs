using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEquipo
{
    internal class DetalleCarrito
    {
        private string sku;
        private double cantidad;
        private int idcarrito;


        //get y set de la clase//

        public string Sku { get { return sku; } set { sku = value; }
        }
        public double Cantidad { get { return cantidad; } set { cantidad = value; }
        }
        public int Idcarrito { get { return idcarrito; } set { idcarrito = value; }
        }
    }
}
