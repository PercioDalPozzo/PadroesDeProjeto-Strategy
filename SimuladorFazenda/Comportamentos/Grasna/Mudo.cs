using SimuladorFazenda;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public class Mudo : ISomDePato
    {
        private Timer timer;
        private UserControl _info;
        private Size _sizeInfo;

        public Mudo(IEmisorSom emisorSom)
        {
            _info = emisorSom.Info;
            _sizeInfo = emisorSom.Info.Size;

            timer = new Timer();
        }

        public void EmiteSom()
        {
            Console.WriteLine("/*** Não emite som ***/");
        }


        public void Dispose()
        {
            _info.Size = _sizeInfo;
            _info.BackgroundImage = null;
            timer.Dispose();
        }
    }
}
