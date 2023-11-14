using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    public class Henger
    {
        private int magassag;
        private int sugar;
        static int szuletesSzamlalo;

        public Henger(int magassag, int sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            SzuletesSzamlalo++;
        }

        public int GetMagassag
        {
            get => default;
            set
            {
            }
        }

        public int GetSugr
        {
            get => default;
            set
            {
            }
        }

        public static int SzuletesSzamlalo
        {
            get => default;
            set
            {
            }
        }
        public Henger(double sugar, double magassag, double fajsuly) : this(sugar, magassag)
        {
         asd
        }

        public virtual double Terfogat()
        {
            return Math.PI * sugar * sugar * magassag;
        }

        public override string ToString()
        {
            return $"Henger: sugar = {sugar}, magasság = {magassag}, térfogat = {Terfogat():N2}";
        }
    }
}