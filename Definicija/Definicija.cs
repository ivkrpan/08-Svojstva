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

            // TODO: Javno dostupno polje Prezime nadomjestiti svojstvom (property) koje se izvan klase može samo čitati, a mijenjati se može samo iz klase

            public string Prezime;


            // TODO: Javno dostupno polje Ime nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali prilikom zadavanja treba onemogućiti
            // zadavanje praznim znakovnim nizom. U tom slučaju treba baciti iznimku tipa ArgumentNullException

            public string Ime;


            // TODO: Javno dostupno polje DatumRođenja nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali za slučaj zadavanja
            // datuma većeg od trenutnog treba baciti iznimku tipa ArgumentOutOfRangeException. U pozivajućem kodu staviti odogovarajući kod za hvatanje
            // iznimke koji će u slučaju iznimke ispisati odgovarajuću poruku.

            public DateTime DatumRođenja;


            public override string ToString()
            {
                return string.Format("{0}, {1}, rođen {2}", Prezime, Ime, DatumRođenja.ToShortDateString());
            }
        }

        static void Main(string[] args)
        {
            // TODO: Primijeniti svojstva u klasi Osoba prema uputama te provjeriti donjim kodom ispravnost promjena
            // (zakomentirati one naredbe dolje koje će uzrokovati pogrešku pri prevođenju nakon promjena u klasi Osoba)

            Osoba o1 = new Osoba("Oliver", "Mlakar");
            Console.WriteLine(o1);

            o1.DatumRođenja = new DateTime(1933, 4, 13);
            Console.WriteLine(o1);

            o1.Ime = "Pero";
            o1.Prezime = "Kvrgić";
            Console.WriteLine(o1);

            o1.DatumRođenja = new DateTime(2020, 4, 13);
            Console.WriteLine(o1);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
