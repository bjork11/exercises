using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namnVektor = new string[5];
            string answer = " ";
            bool wrongInput = false;

            Console.WriteLine("Skriv in namnen på dina 5 favoritdjur!");

            //Mata in namnen på dina 5 favoritdjut
            for (int i = 0; i < namnVektor.Length; i++)
            {
                Console.Write("Namn " + i + ": ");
                string namn = Console.ReadLine();
                namnVektor[i] = namn;
            }

            //Skriv ut att namn som användaren matat in
            Console.Write("Namnen du matat in är: ");
            foreach (string name in namnVektor)
            {
                Console.Write("{0} ", name);
            }

            //loop som körs igen ifall användaren gör en felaktig inmatning
            do
            {
                try
                {
                    wrongInput = false;
                    Console.ReadLine();
                    Console.WriteLine("\nDu kan nu byta ut ett namn på den indexplats du väljer!");
                    Console.WriteLine("(Skriv Q för att avsluta!)");
                    Console.Write("Välj mellan plats 0-4: ");
                    answer = Console.ReadLine();
                    answer = answer.ToUpper();

                    //Så länge användaren inte vill avsluta körs det under if
                    if (answer != "Q")
                    {
                        int indexPlats = Convert.ToInt32(answer);
                        Console.Write("Vilket namn ska in på plats " + (indexPlats) + "? ");
                        string nyttNamn = Console.ReadLine();
                        namnVektor[indexPlats] = nyttNamn;

                        int index = 0;
                        Console.WriteLine("Namnen du matat in är: ");
                        foreach (string name in namnVektor)
                        {
                            Console.WriteLine(index + ": " + name + " ");
                            index++;
                        }
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\nDu vill inte byta ut något namn!");
                    }
                }
                catch
                {
                    Console.WriteLine("\nOm du hade läst instruktionerna hade du inte hamnat här. Det enda som accepteras är 0-4 eller q!");
                    Console.WriteLine("Gör om gör rätt är du gullig!");
                    wrongInput = true;
                }
            } while (wrongInput);

            Console.WriteLine("Nu avslutas programmet!");
            Console.ReadLine();
        }
    }
}
