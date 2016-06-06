using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAuto
{
    class ClassCarros
    {

        public String Matricula;

        public String Kms;

        public Int32 ClienteIdCliente;

        public Int32 IdCarro;

        private List<ClassServicos> _ClassServicos;

        public List<ClassServicos> ClassServicos
        {
            get
            {
                return _ClassServicos;
            }
        }

        public ClassCarros(Int32 IdCarro, String Matricula, Int32 ClienteIdCliente, String Kms)
        {
            this.IdCarro = IdCarro;
            this.Matricula = Matricula;
            this.ClienteIdCliente = ClienteIdCliente;
            this.Kms = Kms; ;
            _ClassServicos = new List<ClassServicos>();
        }
        public override string ToString()
        {
            return IdCarro.ToString() + " - " + Matricula + " | " + Kms + " KMS";
        }
    }
}
