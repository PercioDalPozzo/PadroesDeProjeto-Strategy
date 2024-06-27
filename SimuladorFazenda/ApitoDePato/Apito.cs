using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.ApitoDePato
{
    public class Apito : IApito
    {
        private ISomDePato somDePato;
        public Apito()
        {
            somDePato = new Grasna();
        }

        public void Apitar()
        {
            somDePato.EmiteSom();
        }

        public void Display()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("APITO");
        }
    }
}
