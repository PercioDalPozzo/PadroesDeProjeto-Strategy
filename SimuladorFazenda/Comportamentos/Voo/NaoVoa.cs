using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public class NaoVoa : IVoador
    {
        private Timer timer;
        private UserControl _image;
        private Bitmap[] cells = new Bitmap[2];

        public NaoVoa(Pato pato)
        {
            timer = new Timer();
            _image = pato.Asa;

            cells = new Bitmap[2];
            cells[0] = SimuladorFazenda.Properties.Resources.MaoParada;
            cells[1] = SimuladorFazenda.Properties.Resources.MaoParada2;

            _image.BackgroundImage = cells[0];
        }

        public void Voar()
        {
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private Random cell = new Random();
        void timer1_Tick(object sender, EventArgs e)
        {
            var f = cell.Next(1, 4);
            if (f == 3)
            {
                _image.BackgroundImage = cells[1];
            }
            else
            {
                _image.BackgroundImage = cells[0];
            }
        }

        public void Dispose()
        {
            _image.BackgroundImage = null;
            timer.Dispose();
        }
    }
}
