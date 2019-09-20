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
                Console.Write("Namn " + i + ": ");
                string namn = Console.ReadLine();
                namnVektor[i] = namn;
            }

            Console.Write("Namnen du matat in är: ");
            foreach (string i in namnVektor)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadLine();
            Console.WriteLine("\nDu kan nu byta ut ett namn på den indexplats du väljer!");
            Console.WriteLine("(Skriv Q för att avsluta!)");
            Console.Write("Välj mellan 0-4: ");
            string svar = Console.ReadLine();
            svar = svar.ToUpper();

            if (svar != "Q")
            {
                int indexPlats = Convert.ToInt32(svar);
                Console.Write("Vilket namn ska in på plats " + (indexPlats) + "? ");
                string nyttNamn = Console.ReadLine();
                namnVektor[indexPlats] = nyttNamn;

                int index = 0;
                Console.WriteLine("Namnen du matat in är: ");
                foreach (string namn in namnVektor)
                {
                    Console.WriteLine(index + ": " + namn + " ");
                    index++;
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Du vill inte byta ut något namn!");
            }

            Console.WriteLine("Nu avslutas programmet!");
            Console.ReadLine();
        }
    }
}
