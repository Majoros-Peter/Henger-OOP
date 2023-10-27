namespace HengerOOP
{
    internal class Cso : Henger
    {
        private double falVastagsag;

        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            falVastagsag = 1;
        }

        public double FalVastagsag { get => falVastagsag; }

        public override double Terfogat() => base.Terfogat() - Math.Pow(GetSugar - falVastagsag, 2) * Math.PI * GetMagassag;
        public override string ToString() => base.ToString()+$" falvastagsága:{falVastagsag}";
    }
}