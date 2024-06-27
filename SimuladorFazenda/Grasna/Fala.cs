using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Fala : ISomDePato
    {
        private IFalador falador;

        public Fala()
        {
            this.falador = new Falador();
        }

        public void EmiteSom()
        {
            falador.Fala();
        }
    }
}
