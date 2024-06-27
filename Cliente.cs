using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEquipo
{
    internal class Cliente:Tarjeta
    {
        private int idcliente;
        private string nombre;
        private string direccion;
        private int cp;
        private string estado;
        private string municipio;
        private string correo;
        private int telefono;
        private string rfc;
        private string referencia;
        private List<Tarjeta> tarjetas;

        //get y set de la clase//

        public int Idcarrito
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion 
        {
            get { return direccion; } 
            set { direccion = value; } 
        }
        public int Cp
        {
            get { return cp; }
            set { cp = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }
        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        public List<Tarjeta>Tarjetas
        {
            get { return tarjetas; }
            set { tarjetas = value; }
        }
    }
}
