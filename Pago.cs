using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEquipo
{
    internal class Pago
    {
        private int idpagos;
        private DateTime fecha;
        private string formapago;
        private double monto;
        private int cve;
        private string cliente;


        //get y set de la clase//

        public int Idpagos { get { return idpagos; } set { idpagos = value; }
        }
        public DateTime Fecha { get { return fecha; } set { fecha = value; }
        }
        public string Formapago { get { return formapago; } set { formapago = value; }
        }
        public double Monto { get { return monto; } set { monto = value; }
        }
        public int Cve { get { return cve; } set { cve = value; }
        }
        public string Cliente{ get { return cliente; } set { cliente = value; }
        }

    }
}
