﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Vsite.CSharp
{
    // primjer svojstava sa stringom kao parametrom
    public class PoštanskiBrojevi
    {
        private Dictionary<int, string> popis = new Dictionary<int,string>()
        {
            { 10000, "Zagreb" },
            { 10360, "Sesvete" },
            { 10020, "Novi Zagreb" },
            { 21000, "Split" },
            { 31000, "Osijek" },
            { 41000, "Varaždin" },
            { 51000, "Rijeka" }
        };

        // Definirati svojstvo s int kao parametrom koje će za zadani poštanski broj vratiti mjesto. Otkomentirati naredbu u metodi IspišiNazivMjesta, pokrenuti program i testove.

        public string this[int poštanskiBroj]
        {
            get { 
                return popis[poštanskiBroj];
            }
        }


        // Definirati svojstvo sa string kao parametrom koje će za zadano mjesto vratiti poštanski broj. Otkomentirati naredbu u metodi IspišiPoštanskiBroj, pokrenuti program i testove.

        public int this[string mjesto]
        {
            get
            {
                return popis.First(de => de.Value == mjesto).Key;
            }
        }

    }

    class Indekseri
    {
        static PoštanskiBrojevi pb = new PoštanskiBrojevi();

        static void IspišiNazivMjesta(int poštanskiBroj)
        {
            try
            {
                Console.WriteLine("Poštanski broj {0} ima: {1}", poštanskiBroj, pb[poštanskiBroj]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void IspišiPoštanskiBroj(string mjesto)
        {
            try
            {
                Console.WriteLine("Poštanski broj za {0} je: {1}", mjesto, pb[mjesto]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            IspišiNazivMjesta(21000);
            IspišiNazivMjesta(11111);
            IspišiPoštanskiBroj("Split");
            IspišiPoštanskiBroj("Nečujam");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
