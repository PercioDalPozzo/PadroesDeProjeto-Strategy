using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PatoFalante : Pato
    {        
        public PatoFalante()
        {
            this.Voador = new Voo();
            this.SomDePato = new Fala();           
        }

        public void Display()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("(FALANTE) Eu sou um pato que fala.");
        }
    }
}
