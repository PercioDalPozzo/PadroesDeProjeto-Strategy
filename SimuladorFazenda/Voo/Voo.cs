using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Voo : IVoador
    {
        public void Voa()
        {
            Console.WriteLine("Voando como o vento");
        }
    }
}
