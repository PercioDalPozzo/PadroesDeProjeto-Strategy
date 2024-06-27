using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Pato
    {
        public IVoador Voador;
        public ISomDePato SomDePato;

        public void SetVoador(IVoador v)
        {
            Voador = v;
        }

        public void SetEmisorDeSom(ISomDePato f)
        {
            SomDePato = f;
        }

        public void performSom()
        {
            SomDePato.EmiteSom();
        }

        public void performVoo()
        {
            Voador.Voa();
        }

    }
}
