using System;

namespace Svojstva
{
    class PostanskiBrojevi
    {
        private int[] m_brojevi = new int[] { 10000, 
                                              10360,
                                              10020 
                                            };
        private string[] m_mjesta = new string[] { "Zagreb",
                                                   "Sesvete",
                                                   "Novi Zagreb" 
                                                 };

        public int this[string mjesto]
        {
            get {
                int n = Array.IndexOf(m_mjesta, mjesto);
                if (n < 0)
                    throw new IndexOutOfRangeException(string.Format("Nepoznato mjesto: {0}", mjesto));
                return m_brojevi[n];
            }
        }

        public string this[int postanskiBroj]
        {
            get
            {
                int n = Array.IndexOf(m_brojevi, postanskiBroj);
                if (n < 0)
                    throw new IndexOutOfRangeException(string.Format("Nepoznati poštanski broj: {0}", postanskiBroj));
                return m_mjesta[n];
            }
            set
            {
                int n = Array.IndexOf(m_brojevi, postanskiBroj);
                if (n < 0)
                    throw new IndexOutOfRangeException(string.Format("Nepoznati poštanski broj: {0}", postanskiBroj));
                m_mjesta[n] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PostanskiBrojevi pb = new PostanskiBrojevi();
                Console.WriteLine("Poštanski broj 10000 ima: {0}", pb[10000]);
                Console.WriteLine("Poštanski broj za Sesvete je: {0}", pb["Sesvete"]);
                pb[10360] = "Babina Greda";
                Console.WriteLine("Poštanski broj 10360 ima: {0}", pb[10360]);
                Console.WriteLine("Poštanski broj za Nečujam je: {0}", pb["Nečujam"]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
