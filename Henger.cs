using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HengerOOP
{
    public class Henger
    {
        private double magassag, sugar;
        private static int szuletesSzamlalo;

        public double GetMagassag { get => magassag; }
        public double GetSugar { get => sugar; }
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }

        public Henger(double sugar, double magassag)
        {
            this.sugar = sugar;
            this.magassag = magassag;
            szuletesSzamlalo++;
        }
        public virtual double Terfogat() => Math.PI * magassag * sugar * sugar;
        public override string ToString() => $"Jellemző >> térfogat:{Terfogat():N2}; sugár:{sugar}; magasság:{magassag};";
    }
}