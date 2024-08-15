namespace ConsoleApplication1
{
    public class FalaPorco : ISomDePorco
    {
        // Composicao
        private IFalador falador;

        public FalaPorco(Porco porco)
        {
            this.falador = new Falador(porco);
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
