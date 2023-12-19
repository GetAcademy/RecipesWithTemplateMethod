namespace RecipesWithTemplateMethod
{
    internal class Oppskrift
    {
        public void Tilbred()
        {
            Blande();
            GjørKlarPorsjoner();
            BehandleMedTemperatur();
        }

        protected virtual void Blande()
        {
        }

        protected virtual void GjørKlarPorsjoner()
        {
        }

        protected virtual void Behandle()
        {
        }
    }
}
