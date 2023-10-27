namespace HengerOOP
{
    internal class TomorHenger : Henger
    {
        private double fajsuly;

        public TomorHenger(double magassag, double sugar, double fajsuly): base(magassag, sugar)
        {
            this.fajsuly = fajsuly;
        }

        public TomorHenger(double magassag, double sugar) : base(magassag, sugar)
        {
            this.fajsuly = 7.87;
        }

        public double GetFajSuly => fajsuly;
        public double Suly => fajsuly * Terfogat();

        public override string ToString() => base.ToString()+$" fajsúly:{fajsuly}";
    }
}