namespace ConsoleApplication1
{
    public class FalaPato : ISomDePato
    {
        // Composicao
        private IFalador falador;

        public FalaPato(Pato pato)
        {
            this.falador = new Falador(pato);
        }

        public void EmiteSom()
        {
            falador.Falar();
        }

        public void Dispose()
        {
            falador.Dispose();
        }
    }
}
