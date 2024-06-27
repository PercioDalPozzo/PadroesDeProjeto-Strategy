using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFazenda.ComportamentoVoo
{
    public partial class Voo : IVoador
    {
        private Timer timer;
        private UserControl _image;
        private Bitmap[] cells = new Bitmap[4];

        public Voo(Pato pato)
        {
            timer = new Timer();           
            _image = pato.Asa;

            cells = new Bitmap[4];
            cells[0] = Properties.Resources.Asa1;
            cells[1] = Properties.Resources.Asa2;
            cells[2] = Properties.Resources.Asa3;
            cells[3] = Properties.Resources.Asa4;
        }

        public void Voar()
        {
            this.timer.Enabled = true;
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private int cell = 0;
        void timer1_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1: _image.BackgroundImage = cells[0]; break;
                case 2: _image.BackgroundImage = cells[1]; break;
                case 3: _image.BackgroundImage = cells[2]; break;
                case 4: _image.BackgroundImage = cells[3]; break;
                case 5: _image.BackgroundImage = cells[2]; break;
                default:
                    _image.BackgroundImage = cells[1];
                    cell = 0; break;
            }
        }

        public void Dispose()
        {
            _image.BackgroundImage = null;
            timer.Dispose();            
        }
    }
}
