namespace Gatter
{
    public abstract class GatterSingleInput
    {
        // Attribute
        protected bool e0;
        protected string bezeichnung;
        protected bool a;
        public bool Result { get { return a; } }

        public GatterSingleInput() { }

        public virtual void eingeben(bool e0)
        {
            this.e0 = e0;
        }
        public abstract void berechnen();
        public virtual string ausgebenSF()
        {
            return "Gatterfunktion: " + this.bezeichnung + ", e0: " + this.e0 + ", Ergebnis: " + this.a;
        }
    }
}
