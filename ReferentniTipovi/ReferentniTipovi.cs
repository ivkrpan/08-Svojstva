using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Vsite.CSharp
{
    public class ReferentniTipovi
    {
        public class Smočnica
        {
            public Smočnica()
            {
                Namirnice = new List<string>(new string[] {"kruh", "mlijeko"});
            }


            // TODO: Promijeniti get metodu svojstva Namirnice tako da se onemogući promjena sadržaja liste izvan klase (tj. da naredba Debug.Assert u metodi Main ne baci iznimku)
            public List<string> Namirnice { get; private set; }
        }


        static void Main(string[] args)
        {
            Smočnica s = new Smočnica();
            s.Namirnice.Add("špek");
            
            foreach (var a in s.Namirnice)
                Console.WriteLine(a);

            Debug.Assert(s.Namirnice.Count() == 2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
