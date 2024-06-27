using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public class PatoMudo : Pato
    {
        public PatoMudo(Form mundo)
            : base(mundo)
        {
            SetIdentificacao("Pato mudo");
            SetVoador(new NaoVoa(this));
            SetEmisorDeSom(new Mudo(this));
        }

    }
}
