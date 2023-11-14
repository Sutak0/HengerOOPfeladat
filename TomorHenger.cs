using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    public class TomorHenger : Henger
    {
        private int fajsuly;

        public int GetFajsuly
        {
            get => default;
            set
            {
            }
        }

        public int Suly
        {
            get => default;
            set
            {
            }
        }

        public TomorHenger(double sugar, double magassag, double vasFajsuly) : base(sugar, magassag)
        {
            this.vasFajsuly = vasFajsuly;
        }

        public TomorHenger(double sugar, double magassag) : this(sugar, magassag, 7.87)
        {
        }
        public override double Terfogat()
        {
            return Math.PI * sugar * sugar * magassag;
        }
        public override string ToString()
        {
            return $"TömörHenger: sugar = {sugar}, magasság = {magassag}, vas fajsúly = {vasFajsuly}, térfogat = {Terfogat():N2}";
        }
    }
}