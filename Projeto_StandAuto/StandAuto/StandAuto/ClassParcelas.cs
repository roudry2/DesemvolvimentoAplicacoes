using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAuto
{
    class ClassParcelas
    {
        public Int32 IdParcela;

        public String Valor;

        public String Descricao;

        public ClassParcelas(Int32 IdParcela, String Valor, String Descricao)
        {
            this.IdParcela = IdParcela;
            this.Valor = Valor;
            this.Descricao = Descricao;
        }

        public override string ToString()
        {
                return Valor + "€ " + Descricao;
        }
    }
}
