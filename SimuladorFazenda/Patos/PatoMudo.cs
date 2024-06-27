using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PatoMudo : Pato
    {
        public PatoMudo()
        {
            this.Voador = new NaoVoa();
            this.SomDePato = new Mudo();
        }

        public void Display()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("(MUDO) Eu sou um pato mudo que não fala");
        }
    }
}
