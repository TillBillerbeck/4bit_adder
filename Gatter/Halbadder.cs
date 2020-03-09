using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gatter
{
    public class HalbAdder : GatterDualInput
    {
        protected bool cOut;
        protected bool s;
        public override void berechnen()
        {
            this.cOut = AndGatter.Berechnen(this.e0, this.e1);
            this.s = XorGatter.Berechnen(this.e0, this.e1);
        }

        public static object Berechnen(bool e0, bool e1)
        {
            bool s = XorGatter.Berechnen(e0, e1);
            bool c = AndGatter.Berechnen(e0, e1);
            return new { Sum = s, CarryOut = c };
        }
    }
}
