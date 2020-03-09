namespace Gatter
{
    public class NotGatter : GatterSingleInput
    {
        public NotGatter()
        {
            this.bezeichnung = "NOT";
        }
        public override void berechnen()
        {
            this.a = !this.e0;
        }

        public static bool Berechnen(bool e0)
        {
            return !e0;
        }
    }

    public class AndGatter : GatterDualInput
    {
        public AndGatter()
        {
            this.bezeichnung = "AND";
        }
        public override void berechnen()
        {
            this.a = (this.e0 && this.e1);
        }

        public static bool Berechnen(bool e0, bool e1)
        {
            return (e0 && e1);
        }

    }
    public class NandGatter : GatterDualInput
    {
        public NandGatter()
        {
            this.bezeichnung = "NAND";
        }
        public override void berechnen()
        {
            this.a = !(this.e0 && this.e1);
        }

        public static bool Berechnen(bool e0, bool e1)
        {
            return !(e0 && e1);
        }
    }

    public class OrGatter : GatterDualInput
    {
        public OrGatter()
        {
            this.bezeichnung = "OR";
        }

        public override void berechnen()
        {
            this.a = (this.e0 || this.e1);
        }

        public static bool Berechnen(bool e0, bool e1)
        {
            return (e0 || e1);
        }
    }
    public class NorGatter : GatterDualInput
    {
        public NorGatter()
        {
            this.bezeichnung = "NOR";
        }

        public override void berechnen()
        {
            this.a = !(this.e0 || this.e1);
        }

        public static bool Berechnen(bool e0, bool e1)
        {
            return !(e0 || e1);
        }
    }

    public class XorGatter : GatterDualInput
    {
        public XorGatter()
        {
            this.bezeichnung = "XOR";
        }

        public override void berechnen()
        {
            this.a = (this.e0 ^ this.e1);
        }

        public static bool Berechnen(bool e0, bool e1)
        {
            return (e0 ^ e1);
        }
    }

    public class AntivalenzGatter : GatterDualInput
    {
        public AntivalenzGatter()
        {
            this.bezeichnung = "Antivalenz";
        }
        public override void berechnen()
        {
            this.a = !(this.e0 == this.e1);
        }

        public static bool Berechnen(bool e0, bool e1)
        {
            return !(e0 == e1);
        }
    }

    public class AequivalenzGatter : GatterDualInput
    {
        public AequivalenzGatter()
        {
            this.bezeichnung = "Aequivalenz";
        }

        public override void berechnen()
        {
            this.a = (this.e0 == this.e1);
        }

        public static bool Berechnen(bool e0, bool e1)
        {
            return (e0 == e1);
        }
    }
}
