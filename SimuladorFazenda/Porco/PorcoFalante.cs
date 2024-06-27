using SimuladorFazenda;
using SimuladorFazenda.ComportamentoVoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PorcoFalante : Porco
    {

        public PorcoFalante(Fazenda fazenda)
            : base(fazenda)
        {
            SetIdentificacao("Porco falante");
            SetEmisorDeSom(new FalaPorco(this));
        }

       
    }
}
