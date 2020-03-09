using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gatter
{
    public class VollAdder : HalbAdder
    {
        private bool cIn;

        public override void berechnen()
        {
            // s->.Item1, c->.Item2
            // In den ersten Halbadder kommen e0 und e1
            var halbAdder1 = HalbAdder.Berechnen(this.e0, this.e1);
            // In den zweiten Halbadder kommen der übergebene Übertrag und die Summe aus dem ersten Halbadder
            var halbAdder2 = HalbAdder.Berechnen(halbAdder1.. , this.cIn);

            this.s = halbAdder2.Item2;

            this.cOut = OrGatter.Berechnen(halbAdder1.Item2, halbAdder1.Item1);
        }

        public new static Tuple<bool, bool> Berechnen(bool e0, bool e1, bool cIn)
        {
            // s->.Item1, c->.Item2
            var halbAdder1 = HalbAdder.Berechnen(e0, e1);
            var halbAdder2 = HalbAdder.Berechnen(halbAdder1.Item2, cIn);

            bool s = halbAdder2.Item2;

            bool cOut = OrGatter.Berechnen(halbAdder1.Item2, halbAdder1.Item1);

            return new Tuple<bool, bool>(s, cOut);
        }
    }
}
