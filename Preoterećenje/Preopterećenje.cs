using System;

namespace Vsite.CSharp
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    class Preopterećenje
    {
        // TODO: Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod.



        // svojstvo se ne može preopterećivati
        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }

        // TODO: Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int.




        static void Main(string[] args)
        {
        }
    }
}
