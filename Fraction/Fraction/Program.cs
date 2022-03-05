using System;

namespace Fraction
{
    class Fraction
    {
         static void Main(string[] args)
         {
            Fraction j = new Fraction(8, 4);
            Fraction k = new Fraction(j);


            Fraction[] ff = new Fraction[]
            {
                new Fraction(8, 4),
                new Fraction(8, 24),
                new Fraction(8, 14)
            };



             System.Console.WriteLine(k);
             System.Console.WriteLine("Hello World!");
         }

        public int Licznik { get; private set; }
        public int Mianownik { get; private set; }

        //private int licznik;
        //private int mianownik;
        public Fraction(int licznik, int mianownik)
        {
            this.Licznik = licznik;
            this.Mianownik = mianownik;


        }
        public Fraction(Fraction previousFraction)
        {
            Licznik = previousFraction.Licznik;
            Mianownik = previousFraction.Mianownik;

        }
        /*
        public int Licznik
        {
            get { return licznik;  }
        }

        public int getLicznik()
        {
           return licznik;
        }
        */

        public override string ToString()
        {
            //return base.ToString();

            return Licznik + " / " + mianownik;
        }
    }
}
