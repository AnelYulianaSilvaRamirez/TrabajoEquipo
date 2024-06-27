using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEquipo
{
    internal class ListaProducto
    {
        private string itm;
        private double precio;
        private string descripcion;
        private string unodad;


        //get y set de la clase//

        public string Itm { get { return itm; } set { itm = value; }
        }
        public double Precio { get { return precio; } set { precio = value; }
        }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
    }
}
