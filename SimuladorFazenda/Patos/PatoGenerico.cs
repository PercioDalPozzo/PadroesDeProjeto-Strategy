using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PatoGenerico : Pato
    {
        public PatoGenerico()
        {
            this.Voador = new NaoVoa();
            this.SomDePato = new Mudo();
        }

        public void Display()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("(GENÉRICO) Eu posso ser alterado");          
        }
    }
}
