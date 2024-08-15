using SimuladorFazenda;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public class Falador : IFalador
    {
        private Timer timer;
        private UserControl _info;
        private Size _sizeInfo;

        public Falador(IEmisorSom emisorSom)
        {
            _info = emisorSom.Info;
            _sizeInfo = emisorSom.Info.Size;

            timer = new Timer();
        }

        public void Falar()
        {
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
        }


        private Random ran = new Random();
        private string strFala;
        private bool EmAcao;
        private int parte;

        void timer1_Tick(object sender, EventArgs e)
        {
            if (!EmAcao)
            {
                SortearFala();
            }

            Falar(strFala);
        }

        private void SortearFala()
        {
            var qualquer = ran.Next(10);

            switch (qualquer)
            {
                case 1: { strFala = "♪♪♪♪...|era um garoto|que como eu|♪♪♪♪..."; break; }
                case 2: { strFala = "Adoleta|le-pe-ti|le-pe-ta"; break; }
                case 3: { strFala = "Oi!|Pércio|Ebsen|Dal Pozzo"; break; }
                case 4: { strFala = "Como voce|está?"; break; }
                case 5: { strFala = ":(|To de|saco cheio|:(|:("; break; }
                case 6: { strFala = "Era uma vez|três|porquinhos|a,|deixa pra lá..."; break; }
                case 7: { strFala = "Que fome!!!"; break; }
                case 8: { strFala = "2+2=|?|?|4 :)"; break; }
                case 9: { strFala = "eu não sei pra|onde vou,|pode até não|dar em nada|♪♪♪♪.."; break; }

                default: { strFala = "Falando...|Falando...|Falando..."; break; }
            }
            parte = 0;

            _info.BackgroundImage = SimuladorFazenda.Properties.Resources.BalaoFala;
            _info.BackgroundImageLayout = ImageLayout.Stretch;
            _info.Size = new Size(151, 90);

            EmAcao = true;
        }

        private void Falar(string str)
        {
            var lista = str.Split('|');

            using (Graphics grafico = Graphics.FromImage(_info.BackgroundImage))
            {
                Brush pincel = new SolidBrush(Color.Black);

                Font fonteNome = new Font("Courier New", 12, FontStyle.Bold);

                grafico.DrawString(lista[parte], fonteNome, pincel, 5, parte * 15 + 5);
                _info.Refresh();
            }

            parte++;

            if (parte >= lista.Count())
            {
                EmAcao = false;
            }
        }

        public void Dispose()
        {
            _info.Size = _sizeInfo;
            _info.BackgroundImage = null;
            timer.Dispose();
        }
    }
}
