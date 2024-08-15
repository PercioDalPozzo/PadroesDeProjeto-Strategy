using SimuladorFazenda.ComportamentoVoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PatoFalante : Pato
    {

        public PatoFalante(SimuladorFazenda.Fazenda form1)
            : base(form1)
        {
            SetIdentificacao("Pato falante voador");
            SetVoador(new Voo(this));
            SetEmisorDeSom(new FalaPato(this));
        }       
    }
}
