namespace Gatter
{
    public class AdderOutput
    {
        public bool CarryOut { get; set; }
        public bool Sum { get; set; }

        public AdderOutput(bool cOut, bool sum)
        {
            this.CarryOut = cOut;
            this.Sum = sum;
        }
    }
}
