using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEquipo
{
    internal class Carrito
    {
        private int idcarrito;
        private DateTime fecha;
        private int idcliente;
        private double total;
        private List<DetalleCarrito> detalles;


        //get y set de la clase//

        public int Idcarrito { get { return idcarrito; } set { idcarrito = value; }
        }
        public DateTime Fecha {get { return fecha; } set { fecha = value; }
        }
        public int Idcliente { get { return idcliente; } set { idcliente = value; } 
        }
        public double Total { get { return total; } set { total = value; }
        }
        public List<DetalleCarrito>Detalles { get { return detalles; } set { detalles = value; }
        }
    }
}
