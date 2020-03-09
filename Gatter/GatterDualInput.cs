using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gatter
{
    public abstract class GatterDualInput : GatterSingleInput
    {
        protected bool e1;

        public virtual void eingeben(bool e0, bool e1)
        {
            this.e0 = e0;
            this.e1 = e1;
        }

        public override string ausgebenSF()
        {
            return "Gatterfunktion: " + this.bezeichnung + ", e0: " + this.e0 + ", e1: " + this.e1 + ", Ergebnis: " + this.a;
        }
    }
}
