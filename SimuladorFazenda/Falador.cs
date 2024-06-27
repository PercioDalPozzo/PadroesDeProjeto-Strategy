using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Falador : IFalador
    {
        public void Fala()
        {
            Console.WriteLine("Estou falando a lingua dos HOMENS.");
        }
    }
}
