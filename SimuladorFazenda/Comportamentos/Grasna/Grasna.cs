using SimuladorFazenda;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public class Grasna : ISomDePato
    {
        private Timer timer;
        private UserControl _info;
        private Size _sizeInfo;

        public Grasna(IEmisorSom emisorSom)
        {
            _info = emisorSom.Info;
            _sizeInfo = emisorSom.Info.Size;

            timer = new Timer();
        }

        public void EmiteSom()
        {
            this.timer.Enabled = true;
            this.timer.Interval = 100;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
        }


        private Random ran = new Random();
        private int modo = 2;
        private int count = 1;
        private bool EmAcao = true;
        private string strGrasna;
        private Random controleModo = new Random();
        private int frame;
        private int altura = 1;
        void timer1_Tick(object sender, EventArgs e)
        {
            frame++;
            if (frame % 20 == 0)
            {
                modo = ran.Next(1, 4);
                frame = 0;
                altura = ran.Next(1, 4);
            }

            switch (modo)
            {
                case 1: { _modo1(); break; }
                case 2: { _modo2(); break; }
                case 3: { _modo3(); break; }
                default:
                    break;
            }
        }


        private void _modo1()
        {
            if (EmAcao)
                count++;
            else
                count--;

            switch (count)
            {
                case 1: { strGrasna = "Grasnando"; EmAcao = true; break; }
                case 2: { strGrasna = "gRasnando"; break; }
                case 3: { strGrasna = "grAsnando"; break; }
                case 4: { strGrasna = "graSnando"; break; }
                case 5: { strGrasna = "grasNando"; break; }
                case 6: { strGrasna = "grasnAndo"; break; }
                case 7: { strGrasna = "grasnaNdo"; break; }
                case 8: { strGrasna = "grasnanDo"; break; }
                case 9: { strGrasna = "grasnandO"; EmAcao = false; break; }

                default: { strGrasna = "Grasnando"; break; }
            }
            Grasnar(strGrasna);
        }

        private void _modo2()
        {
            var f = ran.Next(1, 4);

            if (f == 3)
            {
                strGrasna = "QUACK";
            }
            else
            {
                strGrasna = "quack";
            }

            Grasnar(strGrasna);
        }

        private void _modo3()
        {
            if (EmAcao)
                count++;
            else
                count--;

            switch (count)
            {
                case 1: { strGrasna = "QUACK"; EmAcao = true; break; }
                case 2: { strGrasna = " QUACK"; break; }
                case 3: { strGrasna = "  QUACK"; break; }
                case 4: { strGrasna = "   QUACK"; break; }
                case 5: { strGrasna = "    QUACK"; break; }
                case 6: { strGrasna = "     QUACK"; break; }
                case 7: { strGrasna = "      QUACK"; break; }
                case 8: { strGrasna = "       QUACK"; break; }
                case 9: { strGrasna = "        QUACK"; EmAcao = false; break; }


                default: { strGrasna = "Grasnando"; break; }
            }
            Grasnar(strGrasna);
        }


        private void Grasnar(string str)
        {
            _info.BackgroundImage = SimuladorFazenda.Properties.Resources.Balao;
            _info.BackgroundImageLayout = ImageLayout.Stretch;
            _info.Size = new Size(151, 55);

            using (Graphics grafico = Graphics.FromImage(_info.BackgroundImage))
            {
                Brush pincel = new SolidBrush(Color.Black);

                Font fonteNome = new Font("Courier New", 12, FontStyle.Bold);

                grafico.DrawString(str, fonteNome, pincel, 5, 10 * altura + 2);
            }

            _info.Refresh();
        }

        public void Dispose()
        {
            _info.Size = _sizeInfo;
            _info.BackgroundImage = null;
            timer.Dispose();
        }
    }
}
