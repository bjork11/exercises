using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namnVektor = new string[5];

            Console.WriteLine("Skriv in förnamnen på dina 5 bästa kompisar!");

            for (int i = 0; i < namnVektor.Length; i++)
            {
                Console.Write("Namn " + (i + 1) + ": ");
                string namn = Console.ReadLine();
                namnVektor[i] = namn;
            }

            Console.Write("Namnen du matat in är: ");
            foreach(string i in namnVektor)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
