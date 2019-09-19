using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool loop = false;

            do
            {
                loop = false;
                try
                {
                    Console.Write("Hur många tal vill du mata in? ");
                    int antalTal = Convert.ToInt32(Console.ReadLine());
                    int[] talVektor = new int[antalTal];

                    for (int i = 0; i < talVektor.Length; i++)
                    {
                        Console.Write("Mata in tal " + (i + 1) + ": ");
                        int tal = Convert.ToInt32(Console.ReadLine());
                        talVektor[i] = tal;
                        sum += tal;
                        Console.WriteLine("Tal " + (i + 1) + ": " + tal);
                    }
                }
                catch
                {
                    Console.WriteLine("Mata enbart in heltal!");
                    loop = true;
                }
            } while (loop);

            Console.WriteLine("Summan av dina tal blir: " + sum);
            Console.ReadKey();
        }
    }
}