using SimuladorFazenda;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public abstract class Porco : UserControl, IEmisorSom
    {
        private string _identificacao;
        private ISomDePorco SomDePorco;

        public UserControl Info { get; set; }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sou o Porco: " + _identificacao);
        }


        public Porco(Form mundo)
        {
            this.Size = new Size(459, 205);
            this.BackgroundImage = SimuladorFazenda.Properties.Resources.Porco;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Parent = mundo;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);

            this.SuspendLayout();




            //Info
            Info = new UserControl();
            Info.Location = new Point(5, 20);
            Info.BackColor = System.Drawing.Color.Transparent;
            Info.Parent = this;
            Info.Click += this.panel1_Click;

            Info.BringToFront();
        }

        public void SetIdentificacao(string identificacao)
        {
            _identificacao = identificacao;
        }

        public void SetEmisorDeSom(ISomDePorco f)
        {
            if (SomDePorco != null)
            {
                SomDePorco.Dispose();
            }
            SomDePorco = f;
        }

        public void performSom()
        {
            SomDePorco.EmiteSom();
        }
    }
}
