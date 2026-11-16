using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHoi! welke opdracht wil je starten?\n\n" +
                "1 - Opdracht 1\n" +
                "2 - Opdracht 2\n");
            string opdracht = Console.ReadLine();

            switch (opdracht)
            {
                case "1":
                    Opdracht1 opdracht1 = new Opdracht1();
                    Console.Clear();
                    opdracht1.Start();
                    break;

                case "2":
                    Opdracht2 opdracht2 = new Opdracht2();
                    Console.Clear();
                    opdracht2.Start();
                    break;

                default:
                    Console.WriteLine("Kies een geldige optie!");
                    break;
            }
        }
    }
}
