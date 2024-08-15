using SimuladorFazenda;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public abstract class Pato : UserControl, IEmisorSom
    {
        private string _identificacao;
        private IVoador Voador;
        private ISomDePato SomDePato;

        public UserControl Asa;
        public UserControl Info { get; set; }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sou o pato: " + _identificacao);
        }


        public Pato(Form mundo)
        {
            this.Size = new Size(300, 185);
            this.BackgroundImage = SimuladorFazenda.Properties.Resources.Pato;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Parent = mundo;

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);

            this.SuspendLayout();


            //asa
            Asa = new UserControl();
            Asa.Size = this.Size;
            Asa.BackColor = System.Drawing.Color.Transparent;
            Asa.BackgroundImage = SimuladorFazenda.Properties.Resources.SemAsa;
            Asa.BackgroundImageLayout = ImageLayout.Stretch;
            Asa.Parent = this;


            //Info
            Info = new UserControl();
            Info.Location = new Point(this.Width - 150, 90);
            Info.BackColor = System.Drawing.Color.Transparent;
            Info.Parent = this;
            Info.Click += this.panel1_Click;

            Info.BringToFront();
        }

        public void SetIdentificacao(string identificacao)
        {
            _identificacao = identificacao;
        }

        public void SetVoador(IVoador v)
        {
            if (Voador != null)
            {
                Voador.Dispose();
            }

            Voador = v;
        }

        public void SetEmisorDeSom(ISomDePato f)
        {
            if (SomDePato != null)
            {
                SomDePato.Dispose();
            }
            SomDePato = f;
        }

        public void performSom()
        {
            SomDePato.EmiteSom();
        }

        public void performVoo()
        {
            Voador.Voar();
        }

    }
}
