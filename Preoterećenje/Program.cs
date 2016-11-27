using System;

namespace Svojstva
{
    class Program
    {
        // svojstvo ne može biti tipa void
        public void Svojstvo1
        {
            get { return; }
        }

        // svojstvo se ne može preopterećivati
        public double Svojstvo2
        {
            get { return Math.PI; }
        }

        public int Svojstvo2
        {
            get { return 3; }
        }

        static void Main(string[] args)
        {
        }
    }
}
