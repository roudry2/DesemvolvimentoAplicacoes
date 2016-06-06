using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAuto
{
    class ClassCliente
    {
        public Int32 IdCliente;

        public String Nome;

        public String NIF;

        public String Morada;

        public String Contacto;

        private List<ClassCarros> _ClassCarros;

        public List<ClassCarros> ClassCarros
        {
            get
            {
                return _ClassCarros;
            }
        
        }

        public ClassCliente(Int32 IdCliente, String Nome, String NIF, String Morada, String Contacto)
        {
            this.IdCliente = IdCliente;
            this.Nome = Nome;
            this.NIF = NIF;
            this.Morada = Morada;
            this.Contacto = Contacto;
            _ClassCarros = new List<ClassCarros>();

        }

        public override string ToString()
        {
            return IdCliente.ToString()+ " - " + Nome + "(" + NIF + ")";
        }



    }
}
