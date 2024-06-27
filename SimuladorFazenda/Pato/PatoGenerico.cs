using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public class PatoGenerico : Pato
    {
        public PatoGenerico(Form mundo)
            : base(mundo)
        {
            SetIdentificacao("Pato genérico");
            SetVoador(new NaoVoa(this));
            SetEmisorDeSom(new Grasna(this));
        }

    }
}
