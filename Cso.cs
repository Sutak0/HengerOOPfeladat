using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    public class Cso : Henger
    {
        private int falVastagsag;

        public int FalVastagsag
        {
            get => default;
            set
            {
            }
        }
        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag, double falVastagsag, double fajsuly) : base(sugar, magassag, fajsuly)
        {
            this.falVastagsag = falVastagsag;
        }
        public override double Terfogat()
        {
            double belsoSugar = sugar - falVastagsag;
            return Math.PI * belsoSugar * belsoSugar * magassag;
        }

        public override string ToString()
        {
            return $"Cso: sugar = {sugar}, magasság = {magassag}, falvastagság = {falVastagsag}, térfogat = {Terfogat():N2}";
        }
    }
}