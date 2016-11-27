using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Vsite.CSharp
{
    class Program
    {
        [Serializable]
        public class Osoba
        {
            public Osoba(string ime, string prezime)
            {
                Ime = ime;
                Prezime = prezime;
            }

            // Serijalizacija zahtijeva da postoji prazni javno dostupni konstruktor
            public Osoba()
            {
            }

            [XmlElement("FamilyName")]
            public string Prezime
            {
                get;
                set;
            }

            public string Ime
            {
                get;
                set;
            }
        }

        [Serializable]
        public class Obitelj
        {
            public Osoba[] Roditelji
            {
                get { return m_roditelji.ToArray(); }
                set { m_roditelji = new List<Osoba>(value); }
            }

            public Osoba[] Djeca
            {
                get { return m_djeca.ToArray(); }
                set { m_djeca = new List<Osoba>(value); }
            }

            private List<Osoba> m_roditelji = new List<Osoba>();
            private List<Osoba> m_djeca = new List<Osoba>();
        }

        static void Main(string[] args)
        {
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Osoba));
                
                // TODO: Dodati konkretno ime i prezime u argumente konstruktora  

                Osoba o = new Osoba("", "");
                // Kreiraj objekt FileStream pomoću kojeg će se XML datoteka zapisati
                using (Stream writer = new FileStream("Osoba.xml", FileMode.Create))
                    serializer.Serialize(writer, o);
            }

            {
                XmlSerializer serializer = new XmlSerializer(typeof(Obitelj));
                Obitelj ob = new Obitelj();

                // TDOD: u niz ob.Djeca umetnuti nekoliko osoba

                ob.Djeca = new Osoba[] {  };
                
                // TODO: u niz ob.Roditelji dodati dvije osobe

                ob.Roditelji = new Osoba[] { };
                // Kreiraj objekt FileStream pomoću kojeg će se XML datoteka zapisati
                using (Stream writer = new FileStream("Obitelj.xml", FileMode.Create))
                    serializer.Serialize(writer, ob);
            }

            // TODO: Pokrenuti program te prekopirati sadržaje generiranih datoteka "Osoba.xml" i "Obitelj.xml" u datoteke priložene projektu

            // TODO: Dodati svojstvu Ime u klasi Osoba korisnički definirani atribut [XmlAttribute("Name")], pokrenuti program i pogledati što se promijenilo u XML datoteci

            Console.WriteLine("Gotovo!!!");
            Console.ReadKey();
        }
    }
}
