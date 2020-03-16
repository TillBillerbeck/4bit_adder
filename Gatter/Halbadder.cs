using System;

namespace Gatter
{

    public class HalbAdder : GatterDualInput
    {
        public HalbAdder() { }

        public HalbAdder(bool cOut, bool sum)
        {
            this.cOut = cOut;
            this.sum = sum;
        }
        protected bool cOut;
        protected bool sum;
        public override void berechnen()
        {
            this.sum = XorGatter.Berechnen(this.e0, this.e1);
            this.cOut = AndGatter.Berechnen(this.e0, this.e1);
        }

        public static AdderOutput Berechnen(bool e0, bool e1)
        {
            bool s = XorGatter.Berechnen(e0, e1);
            bool c = AndGatter.Berechnen(e0, e1);
            return new AdderOutput(cOut: c, sum: s);
        }

        public static AdderOutput Berechnen(decimal e0, decimal e1)
        {
            bool e0_bool = Convert.ToBoolean(e0);
            bool e1_bool = Convert.ToBoolean(e1);
            return HalbAdder.Berechnen(e0_bool, e1_bool);
        }
    }
}
