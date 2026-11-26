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
                "2 - Opdracht 2\n" +
                "3 - Opdracht 3\n" +
                "4 - Opdracht 4\n" +
                "5 - Opdracht 5\n" +
                "6 - Opdracht 6\n" +
                "7 - Opdracht 7\n"); //+
                //"8 - Opdracht 8\n" +
                //"9 - Opdracht 9\n" +
                //"10 - Opdracht 10\n" +
                //"11 - Opdracht 11\n");
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

                case "3":
                    Opdracht3 opdracht3 = new Opdracht3();
                    Console.Clear();
                    opdracht3.Start();
                    break;
                case "4":
                    Opdracht4 opdracht4 = new Opdracht4();
                    Console.Clear();
                    opdracht4.Start();
                    break;
                case "5":
                    Opdracht5 opdracht5 = new Opdracht5();
                    Console.Clear();
                    opdracht5.Start();
                    break;
                case "6":
                    Opdracht6 opdracht6 = new Opdracht6();
                    Console.Clear();
                    opdracht6.Start();
                    break;
                case "7":
                     Opdracht7 opdracht7 = new Opdracht7();
                     Console.Clear();
                     opdracht7.Start();
                     break;
                /* case "8":
                     Opdracht8 opdracht8 = new Opdracht8();
                     Console.Clear();
                     opdracht8.Start();
                     break;*/
                /* case "9":
                    Opdracht9 opdracht9 = new Opdracht9();
                    Console.Clear();
                    opdracht9.Start();
                    break;*/
                /* case "10":
                    Opdracht10 opdracht10 = new Opdracht10();
                    Console.Clear();
                    opdracht10.Start();
                    break;*/
                /* case "11":
                    Opdracht11 opdracht11 = new Opdracht11();
                    Console.Clear();
                    opdracht11.Start();
                    break;*/

                default:
                    Console.WriteLine("Kies een geldige optie!");
                    break;
            }
        }
    }
}
