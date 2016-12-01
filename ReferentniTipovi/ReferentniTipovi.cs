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
                namirnice = new List<string>(new string[] {"kruh", "mlijeko"});
            }


            //  Promijeniti get metodu svojstva Namirnice tako da se onemogući promjena sadržaja liste izvan klase (tj. da naredba Debug.Assert u metodi Main ne baci iznimku)
            public List<string> namirnice ; //{ get; private set; }

            public IEnumerable<string> Namirnice {
                get { 
                    return namirnice;
                }
            }

        }


        static void Main(string[] args)
        {
            Smočnica s = new Smočnica();
            s.namirnice.Add("špek");
            
            foreach (var a in s.Namirnice)
                Console.WriteLine(a);

            Debug.Assert(s.Namirnice.Count() == 2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
