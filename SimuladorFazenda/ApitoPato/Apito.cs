using SimuladorFazenda;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication1.ApitoDePato
{
    public class Apito : UserControl, IApito, IEmisorSom
    {
        public UserControl Info { get; set; }
        private Form _mundo;

        private ISomDePato somDePato;

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sou o apito");
        }

        public Apito(Form mundo)
        {
            this._mundo = mundo;

            this.Size = new Size(330, 199);
            this.BackgroundImage = SimuladorFazenda.Properties.Resources.Apito;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Parent = mundo;

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);

            this.SuspendLayout();



            //Info
            Info = new UserControl();
            Info.Size = new Size(151, 55);
            Info.Location = new Point(5, 100);
            Info.BackColor = System.Drawing.Color.Transparent;
            Info.Parent = this;
            Info.Click += this.panel1_Click;

            Info.BringToFront();


            somDePato = new Grasna(this);
        }

        public void Apitar()
        {
            somDePato.EmiteSom();
        }
    }
}
