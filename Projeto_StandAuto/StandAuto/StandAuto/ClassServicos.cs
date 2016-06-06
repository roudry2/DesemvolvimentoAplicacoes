using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAuto
{
    class ClassServicos
    {
        public Int32 IdServicos;

        public String DataEntrada;

        public String Tipo;

        public String DtaSaida;

        private List<ClassParcelas> _ClassParcelas;

        public List<ClassParcelas> ClassParcelas
        {
            get
            {
                return _ClassParcelas;
            }
        }

        public Decimal TotalValor
        {
            get
            {
                Decimal ValorTotal = 0;
                foreach(ClassParcelas item in _ClassParcelas)
                {
                    ValorTotal += Convert.ToDecimal(item.Valor);
                }
                return ValorTotal;
            }
        }
        public ClassServicos(Int32 IdServicos, String DataEntrada, String Tipo, String DtaSaida)
        {
            this.IdServicos = IdServicos;
            this.DataEntrada = DataEntrada;
            this.Tipo = Tipo;
            this.DtaSaida = DtaSaida;
            _ClassParcelas = new List<ClassParcelas>();
        }
        public override string ToString()
        {
            return IdServicos.ToString() + " - "+ DataEntrada + " | " + DtaSaida + " - " + TotalValor + "€";
        }



    }
}
