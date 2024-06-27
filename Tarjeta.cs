using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEquipo
{
    internal class Tarjeta
    {
        private long idtarjeta;
        private int cve;
        private string formapago;
        private DateTime fecha;
        private int cliente;
        private int monto;

        //get y set de la clase//

        public long Idtarjeta { get { return idtarjeta; } set { idtarjeta = value; } }

        public int Cve { get { return cve; } set { cve = value; } }

        public string Formapago { get { return formapago; } set { formapago = value; } }

        public DateTime Fecha { get { return fecha; } set { fecha = value; } }

        public int Cliente { get { return cliente; } set { cliente = value; } }

        public int Monto { get { return monto; } set { monto = value; } }
    }
}
