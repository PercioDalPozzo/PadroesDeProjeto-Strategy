using ConsoleApplication1;
using ConsoleApplication1.ApitoDePato;
using SimuladorFazenda.ComportamentoVoo;
using SimuladorFazenda.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFazenda
{
    public partial class Fazenda : Form
    {
        private PorcoFalante PorcoFalante;

        private PatoFalante PatoFalante;
        private PatoGenerico PatoGenerico;
        private PatoMudo PatoMudo;

        private Apito Apito;

        public Fazenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatoGenerico = new PatoGenerico(this);
            PatoGenerico.Top = 400;
            PatoGenerico.Left = 10;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatoFalante = new PatoFalante(this);
            PatoFalante.Top = 250;
            PatoFalante.Left = 380;
            PatoFalante.performSom();
            PatoFalante.performVoo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatoGenerico.SetVoador(new Voo(PatoGenerico));
            PatoGenerico.performVoo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Apito = new Apito(this);
            Apito.Top = 30;
            Apito.Left = 400;
            Apito.Apitar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatoGenerico.SetEmisorDeSom(new Grasna(PatoGenerico));
            PatoGenerico.performSom();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PatoGenerico.SetEmisorDeSom(new FalaPato(PatoGenerico));
            PatoGenerico.performSom();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PatoGenerico.SetEmisorDeSom(new Mudo(PatoGenerico));
            PatoGenerico.performSom();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PatoGenerico.SetVoador(new NaoVoa(PatoGenerico));
            PatoGenerico.performVoo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PorcoFalante = new PorcoFalante(this);
            PorcoFalante.Top = 200;
            PorcoFalante.Left = 800;
            PorcoFalante.performSom();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PatoMudo = new PatoMudo(this);
            PatoMudo.Top = 450;
            PatoMudo.Left = 700;
            PatoMudo.performSom();
            PatoMudo.performVoo();
        }



    }
}
