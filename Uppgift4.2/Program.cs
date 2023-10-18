using System;
namespace Uppgift4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxTal = 0;
            bool cont = true;
            int svar;

            do
            {
                Console.WriteLine("Skriv in ett heltal");
                svar = int.Parse(Console.ReadLine());

                if (svar > maxTal)
                {
                    maxTal = svar;
                }

                Console.WriteLine("Vill du skriva in ett heltal till?");
                Console.WriteLine("[J]a");
                Console.WriteLine("[N]ej");
                if (Console.ReadLine().ToLower() == "n") //kollar om de sa nej och avslutar loopen då
                {
                    cont = false;
                }
            } while (cont);

            Console.WriteLine($"Det största talet du skrev var {maxTal}.");

            Console.WriteLine("Tryck på valfri tangent för att avsluta");
            Console.ReadKey();
        }
    }
}