using System;

namespace Vsite.CSharp
{
    public class Definicija
    {
        public class Osoba
        {
            public Osoba(string ime, string prezime)
            {
                this.Ime = ime;
                Prezime = prezime;
            }

            // Javno dostupno polje Prezime nadomjestiti svojstvom (property) koje se izvan klase može samo čitati, a mijenjati se može samo iz klase

          //  public string Prezime;
            public string Prezime { get; private set; }


            // Javno dostupno polje Ime nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali prilikom zadavanja treba onemogućiti
            // zadavanje praznim znakovnim nizom. U tom slučaju treba baciti iznimku tipa ArgumentNullException

            // public string Ime;
            string ime;
            public string Ime {
                get { return ime; }
                set {
                    if (value == null || value.Length == 0)
                        throw new ArgumentNullException();
                    ime = value; }
                            }
            
            // Javno dostupno polje DatumRođenja nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali za slučaj zadavanja
            // datuma većeg od trenutnog treba baciti iznimku tipa ArgumentOutOfRangeException. U pozivajućem kodu staviti odogovarajući kod za hvatanje
            // iznimke koji će u slučaju iznimke ispisati odgovarajuću poruku.

            DateTime datumRođenja;
            public DateTime DatumRođenja {
                get { return datumRođenja; }

                set {
                    if (value >= DateTime.Today) {

                        throw new ArgumentOutOfRangeException();
                                            
                    }
                    datumRođenja = value;
                }  
            }

            public override string ToString()
            {
                return string.Format("{0}, {1}, rođen {2}", Prezime, Ime, datumRođenja.ToShortDateString());
            }
        }

        static void Main(string[] args)
        {
            // Primijeniti svojstva u klasi Osoba prema uputama te provjeriti donjim kodom ispravnost promjena
            // (zakomentirati one naredbe dolje koje će uzrokovati pogrešku pri prevođenju nakon promjena u klasi Osoba)

            Osoba o1 = new Osoba("Oliver", "Mlakar");
            Console.WriteLine(o1);

            o1.DatumRođenja = new DateTime(1933, 4, 13);
            Console.WriteLine(o1);

            o1.Ime = "Pero";
         //   o1.Prezime = "Kvrgić";
            Console.WriteLine(o1);

            o1.DatumRođenja = new DateTime(2020, 4, 13);
            Console.WriteLine(o1);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
