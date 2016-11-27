using System;

namespace Vsite.CSharp
{
    // primjer definiranja indeksera (svojstava s parametrom)
    // s cjelobrojnim indeksom
    static class DaniUTjednu
    {
        public string this[this int]

        // TODO: Definirati svojstvo s parametrom (indekser) tipa int koji će provjerati proslijeđeni indeks i bacati iznimku tipa IndexOutOfRangeException za slučaj neispravnog indeksa
        // Provjeriti ispravnost koda izvođenjem metode Main

    
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringArray niz = new StringArray(3);
            try
            {
                //niz[0] = "Nulti";
                //niz[2] = "Drugi";
                //Console.WriteLine("niz[2] = {0}", niz[2]);
                //Console.WriteLine("niz[1] = {0}", niz[1]);
                //niz[3] = "Treći";
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                //Console.WriteLine("niz[-1] = {0}", niz[-1]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
