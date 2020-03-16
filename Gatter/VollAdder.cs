using System;

namespace Gatter
{
    public class VollAdder : HalbAdder
    {
        private bool cIn;

        public new void eingeben(bool e0, bool e1, bool cIn)
        {
            this.e0 = e0;
            this.e1 = e1;
            this.cIn = cIn;
        }

        public override void berechnen()
        {
            // Aus dem XOR kommt die Summe
            // Aus dem AND kommt der CarryOut
            // In den ersten Halbadder kommen e0 und e1
            var halbAdder1 = HalbAdder.Berechnen(this.e0, this.e1);
            // In den zweiten Halbadder kommen der übergebene Übertrag und die Summe aus dem ersten Halbadder
            var halbAdder2 = HalbAdder.Berechnen(halbAdder1.Sum, this.cIn);

            // Die Summe ist die Summe aus dem zweiten Halbadder
            this.sum = halbAdder2.Sum;

            // Das CarryOut wird aus den CarryOuts der beiden Halbadder berechnet
            this.cOut = OrGatter.Berechnen(halbAdder1.CarryOut, halbAdder2.CarryOut);
        }

        public static AdderOutput Berechnen(bool e0, bool e1, bool cIn)
        {
            var halbAdder1 = HalbAdder.Berechnen(e0, e1);
            var halbAdder2 = HalbAdder.Berechnen(halbAdder1.Sum, cIn);

            bool s = halbAdder2.Sum;

            bool cOut = OrGatter.Berechnen(halbAdder1.CarryOut, halbAdder2.CarryOut);

            return new AdderOutput(cOut: cOut, sum: s);
        }

        public static AdderOutput Berechnen(decimal e0, decimal e1, bool cIn)
        {
            bool e0_bool = Convert.ToBoolean(e0);
            bool e1_bool = Convert.ToBoolean(e1);
            return VollAdder.Berechnen(e0_bool, e1_bool, cIn);
        }


        public static AdderOutput Berechnen(decimal e0, decimal e1, decimal cIn)
        {
            bool e0_bool = Convert.ToBoolean(e0);
            bool e1_bool = Convert.ToBoolean(e1);
            bool cIn_bool = Convert.ToBoolean(cIn);
            return VollAdder.Berechnen(e0_bool, e1_bool, cIn_bool);
        }
    }
}
