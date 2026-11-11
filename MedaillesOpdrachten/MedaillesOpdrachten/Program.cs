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
            Opdracht2 opdracht2 = new Opdracht2();
            opdracht2.Start();
        }
        
        class Opdracht1
        {
            public void Start()
            {
                Console.WriteLine("Opdracht 1 - naam en leeftijd\n");
                Console.WriteLine($"Wat is je naam?");
                string name = Console.ReadLine();
                Console.WriteLine($"Hoi {name}! Hoe oud ben je?");
                string age = Console.ReadLine();
                Console.WriteLine($"Hoi {name}, je bent {age} jaar oud!");
            }
            }
        class Opdracht2 
        {
            public void Start()
            {
                Console.WriteLine("Opdracht 2 - Kamer Keuze tekst-game\n");
                string choice = "";

                Console.WriteLine("20:00. \nJe zit in je kamer te doomscrollen, opeens hoor je een deur opengaan. " +
                    "\nJe bent alleen thuis en je ouders zouden pas rond 02:00 terug komen\n");
                Console.WriteLine("Wat doe je?\nA - Niks\nB - Verstop je in je kledingkast\nC - Ga kijken waar dat geluid vandaan kwam\n");
                choice = Console.ReadLine();
                if (choice == "A" || choice == "B" || choice == "C")
                {
                    if (choice == "A")
                    {
                        Console.WriteLine("\n20:00. \nje blijft doomscrollen en zet je volume op max" +
                            "\n20:30. er gaat een half uur voorbij en het lijkt erop dat de indringer afgeschrikt is door je tiktok" +
                            "\n\nGewonnen!\n\nWil je nog een keer proberen? y/n");
                        choice = Console.ReadLine();
                        if (choice == "y")
                        {
                            Task.Delay(1000).Wait();
                            Console.Clear();
                            Opdracht2 opdracht2 = new Opdracht2();
                            opdracht2.Start();
                        }
                        else 
                        {
                            Console.Clear();
                        }
                    }
                    else if (choice == "B")
                    {
                        Console.WriteLine("\n20:00. \nje verstopt je in de kledingkast." +
                            "\nJe hoort voetstappen luider worden en ziet door de deurspleet een wazige gedaante je kamer binnenkomen. " +
                            "\nWat doe je?\nA - Blijf verstopt in je kast\nB - Kom uit de kast en ren zo snel je kan weg" +
                            "\nB - Probeer het mysterieuze figuur aan te vallen als hij niet oplet");
                        choice = Console.ReadLine();
                        if (choice == "A" || choice == "B" || choice == "C")
                        {
                            if (choice == "A")
                            {
                                Console.WriteLine("");
                                choice = Console.ReadLine();
                                
                            }
                            else if (choice == "B")
                            {
                                Console.WriteLine("");
                            }
                            else if (choice == "C")
                            {

                                Console.WriteLine("C");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kies een van de opties!");
                            Task.Delay(1000).Wait();
                            Console.Clear();
                            Opdracht2 opdracht2 = new Opdracht2();
                            opdracht2.Start();
                        }
                    }
                    else if (choice == "C")
                    {
                        Console.Clear();
                        Console.WriteLine("C");
                    }
                }
                else
                {
                    Console.WriteLine("Kies een van de opties!");
                    Task.Delay(1000).Wait();
                    Console.Clear();
                    Opdracht2 opdracht2 = new Opdracht2();
                    opdracht2.Start();
                }
            }
        }
    }
}
