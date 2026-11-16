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

            switch(opdracht)
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Opdracht 2 - Kamer Keuze tekst-game\n");
                string choice = "";

                Console.WriteLine("20:00. \nJe zit in je kamer te doomscrollen, opeens hoor je een deur opengaan. " +
                    "\nJe bent alleen thuis en je ouders zouden pas rond 02:00 terug komen\n");
                Console.WriteLine("Wat doe je?" +
                    "\nA - Niks" +
                    "\nB - Verstop je in je kast" +
                    "\nC - Ga kijken waar dat geluid vandaan kwam\n");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                        NiksDoen();
                        break;

                    case "B":
                        Verstoppen();
                        break;

                    case "C":
                        Kijken();
                        break;

                    default:
                        Console.WriteLine("Kies een geldige optie!");
                        Start();
                        break;
                }

                void gewonnen()
                {
                    Console.WriteLine("\n\nGewonnen!\n\nWil je nog een keer proberen? Y/N");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "Y":
                            Console.Clear();
                            Opdracht2 opdracht2 = new Opdracht2();
                            opdracht2.Start();
                            break;
                        case "N":
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            break;
                    }

                }

                void NiksDoen()
                {
                    Console.WriteLine("\n20:00. \nje blijft doomscrollen en zet je volume op max" +
                                               "\n20:30. er gaat een half uur voorbij en het lijkt erop dat de indringer afgeschrikt is door je tiktok");
                    gewonnen();
                }

                void Verstoppen()
                {
                    Console.WriteLine("\n20:00. \nje verstopt je in de kledingkast." +
                           "\nJe hoort voetstappen luider worden en ziet door de deurspleet een wazige gedaante je kamer binnenkomen. " +
                           "\nWat doe je?" +
                           "\nA - Blijf verstopt in je kast" +
                           "\nB - Ren zo snel je weg als je kan" +
                           "\nC - Probeer het mysterieuze figuur aan te vallen als hij niet oplet");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "A":
                            Blijf();
                            break;

                        case "B":
                            Death();
                            break;

                        case "C":
                            Death();
                            break;

                        default:
                            Console.WriteLine("Kies een geldige optie!");
                            Verstoppen();
                            break;
                    }
                }

                void Blijf()
                {
                    Console.WriteLine("\n20:10. \nje blijft verstopt in de kledingkast." +
                          "\nHet lijkt erop dat de gedaante uit je kamer is" +
                          "\nWat doe je?" +
                          "\nA - Blijf nogsteeds verstopt in je kast" +
                          "\nB - Spring uit het raam in je kamer" +
                          "\nC - Ontdek het huis");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "A":
                            Blijf2();
                            break;

                        case "B":
                            Raam();
                            break;

                        case "C":
                            Ontdek();
                            break;

                        default:
                            Console.WriteLine("Kies een geldige optie!");
                            Blijf();
                            break;
                    }
                }

                void Raam()
                {
                    Console.WriteLine("\n20:10. \nJe springt uit het raam. \nJe rent weg, maar komt het mysterieuze figuur tegen.");
                    System.Threading.Thread.Sleep(1200);
                    Death();
                }

                void Ontdek()
                {
                    Console.WriteLine("\n20:10. \nOntdek het huis" +
                          "\nNaar welke kamer ga je eerst?" +
                          "\nA - Badkamer" +
                          "\nB - Keuken" +
                          "\nC - Woonkamer");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "A":
                            Badkamer();
                            break;

                        case "B":
                            Keuken();
                            break;

                        case "C":
                            Woonkamer();
                            break;

                        default:
                            Console.WriteLine("Kies een geldige optie!");
                            Ontdek();
                            break;
                    }
                }

                void Badkamer()
                {
                    Console.WriteLine("\n20:10. \nJe zit nu in de badkamer, er is hier niemand" +
                          "\nNaar welke kamer ga je nu?" +
                          "\nA - Keuken" +
                          "\nB - Woonkamer" +
                    "\nC - Ik denk niet dat hij er nog is");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "A":
                            Keuken();
                            break;

                        case "B":
                            Woonkamer();
                            break;

                        case "C":
                            gewonnen();
                            break;

                        default:
                            Console.WriteLine("Kies een geldige optie!");
                            Badkamer();
                            break;
                    }
                }

                void Keuken()
                {
                    Console.WriteLine("\n20:10. \nJe zit nu in de keuken, er is hier niemand" +
                          "\nNaar welke kamer ga je nu?" +
                          "\nA - Keuken" +
                          "\nB - Woonkamer" +
                    "\nC - Ik denk niet dat hij er nog is");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "A":
                            Badkamer();
                            break;

                        case "B":
                            Woonkamer();
                            break;


                        case "C":
                            gewonnen();
                            break;

                        default:
                            Console.WriteLine("Kies een geldige optie!");
                            Keuken();
                            break;
                    }
                }

                void Woonkamer()
                {
                    Console.WriteLine("\n20:10. \nJe zit nu in de woonkamer, er is hier niemand" +
                          "\nNaar welke kamer ga je nu?" +
                          "\nA - Keuken" +
                          "\nB - Woonkamer" +
                          "\nC - Ik denk niet dat hij er nog is");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "A":
                            Keuken();
                            break;

                        case "B":
                            Badkamer();
                            break;
                        case "C":
                            gewonnen();
                            break;

                        default:
                            Console.WriteLine("Kies een geldige optie!");
                            Woonkamer();
                            break;
                    }
                }

                void Blijf2()
                {
                    Console.WriteLine("\n20:20. \nje zit nogsteeds verstopt in de kledingkast." +
                                              "\nDe gedaante is nogsteeds niet meer in je kamer" +
                                              "\nWat doe je?" +
                                              "\nA - Blijf verstopt in je kast" +
                                              "\nB - Ontdek het huis");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "A":
                            Blijf3();
                            break;

                        case "B":
                            Ontdek();
                            break;

                        default:
                            Console.WriteLine("Kies een geldige optie!");
                            Blijf2();
                            break;
                    }
                }

                void Blijf3()
                {
                    Console.WriteLine("\n20:50. \n...Ik denk dat het nu wel tijd wordt om uit die kast te komen bro" +
                                              "\nDe gedaante is nogsteeds niet meer in je kamer" +
                                              "\nWat doe je?" +
                                              "\nA - sterf" +
                                              "\nB - Ontdek het huis");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "A":
                            Death();
                            break;

                        case "B":
                            Ontdek2();
                            break;

                        default:
                            Console.WriteLine("Kies een geldige optie!");
                            Blijf3();
                            break;
                    }
                }

                void Ontdek2()
                {
                    Console.WriteLine("\n20:50\nVoorzichtig loop je het hele huis door.\n" +
                        "het lijkt erop dat de misterieuze gedaante je huis heeft verlaten uit verveling");
                    gewonnen();
                }
                void Kijken()
                {
                    Console.WriteLine("Je gaat kijen waar dat geluid vandaan komt en ziet opeens een vreemde gedaante in je ooghoek staan." +
                        "Je blijft zo stil mogelijk en probeert geen geluid te maken. Opeens stap je op een plank die kraakt en de gedaante draait binnen een" +
                        "seconde zijn hoofd naar je. Hij springt op je af en je leven flitst voor je ogen");
                    System.Threading.Thread.Sleep(1200);
                    Death();

                }

                void Death()
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("@@@@@@@@@aOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOdMa@@\r\n@@@@@@@@adOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOa@M\r\n@@@@@@@adOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOddOOOOOOOOOOOOM@M\r\n@@@@@@@aOOOOOdaM@@@@@@@@@@MaOOOOOOOOOOOOOOOOOOaM@@@@@@@@@@@@@MddOddO\r\n@@@@@@@dOOOOM@@@@MaM@Mda@@@@@@aOOOOOOOOOOOOOa@@@@MddM@@adM@@@@@@aMMM\r\n@@@@@@@ada@@@@@aOd@@M@@aOdM@@@@@MMadOOOOOMM@@@@aOOa@MM@@MOOa@@@Md@@@\r\n@@@@@@@M@@@@@@aOOd@@@@@MOOa@@@@@aOOOOOOOd@@@@@MOOOM@@@@@@OOdM@@@@@@@\r\n@@@@@@@@@@@@@@aOOOaM@@MOOdM@@@@@MOOOOOOOOM@@@@MOOOOa@@@MOOdd@@@@@@@@\r\n@@@@@@@@Mdda@@@@@MMMaMMM@Mada@@@MOOOOOOOOaa@M@@@MMaaddMMM@@@@@addM@@\r\n@@@@@@@@@aOOOaaaMMMMMaddOOaaM@@@@dOOOOOOOaOdOaaaMM@@@@@@MMadOOOOO@@@\r\n@@@@@@@@MOOOOOOOOOOOOOOOOOOOaM@@MOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOa@@@\r\n@@@@@@@@@aOOOOOOOOOOOOOOOOOOOd@@@MOOOOOOOOOOOOOOOOOOOa@MadOOOOOa@@@@\r\n@@@@@@@@@aOOOOOOOOOOOOOOOOOOOOM@@MOOOOOOOOOOOOOOOOOOOOdMMdOOOOd@@@@@\r\n@@@@@@@@@@dOOOOOOOOOOOOOOOOOOdM@@MOOOOOOOOOOOOOOOOOOOOOOOOOOOd@@@@@@\r\n@@@@@@@@@@MOOOOOOOOOOOOOOOOOOaM@MdOOOOOOOOOOOOOOOOOOOOOOOOOOdM@@@@@@\r\n@@@@@@@@@@MOOOOOOOOOOOOOOOOOa@@@@@aOOOOOOOOOOOOOOOOOOOOOOOOOM@@@@@@@\r\n@@@@@@@@@@@MdOOOOOOOOOOOOOOa@@@@@@MdOOOOOOOOOdOOOOOOOOOOOOOdM@@@@@@@\r\n@@@@@@@@@@@@aOOOOOOOOOOOdM@@@@@@@@@aOOOOOOOOOdOOOOOOOOOOOOM@@@@@@@@@\r\n@@@@@@@@@@@@MdOOOOOOOOOOd@@@@@@@@@@MddaM@@@@dOOOOOOOOOOOOOM@@@@@@@@@\r\n@@@@@@@@@@@@MaOOOOOOOOOa@@@@@@@@@@@@@@@@@@MOOOOOOOOOOOOOOM@@@@@@@@@@\r\n@@@@@@@@@@@@MaOOOOOOOddM@@@@@@@@@@@@@@M@@dOOOOOOdOOOOOOOO@@@@@@@@@@@\r\n@@@@@@@@@@@@@MaOOOOa@@@@@@@@@@@@@@@MdMdOOOOOOOOOOOOOOOOOM@@@@@@@@@@@\r\n@@@@@@@@@@@@MddOMMaM@@@@@@@@@@@@MOOOOOOOOOOOOOOOOOOdOOOOa@@@@@@@@@@@\r\n@@@@@@@@@@@@@@M@@@@@@@@@@@@@@@@MMOOOOOOOOOOOOOOdM@@@MOOM@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@MM@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@MaOdM@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@MM@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@MaddOdMMa@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@MdOOddM@@@@@@@@@@@@@@@@@@@@@@@M@dOOdadda@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@aMaOOOdOOOdaM@@aM@aaaMOOOaOOdOddadaadaM@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@MOddddOOOOOOOddOOdOOOaOOOOOOOOddMdaM@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@MaaaaaaaddaaOOOOOOOOOOOOdaa@MadOOd@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@adOdOdOdMaadOOOOOOOOOdaOOOOOOM@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@MMMOOOdMadaOddOdOOOOdOOOddM@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@adOdOOdOOdOOOOdddada@@@@@@@@aM@@@@@@@@@");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Threading.Thread.Sleep(333);
                    Console.Write("het");
                    System.Threading.Thread.Sleep(400);
                    Console.Write(" is");
                    System.Threading.Thread.Sleep(400);
                    Console.Write(" koud");
                    System.Threading.Thread.Sleep(400);
                    Console.Write("\nalles ");
                    System.Threading.Thread.Sleep(400);
                    Console.Write("is");
                    System.Threading.Thread.Sleep(400);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(400);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(400);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(600);
                    Console.Write(" stil");
                    System.Threading.Thread.Sleep(1000);
                    {
                        Console.WriteLine("\n\nWil je nog een keer proberen? Y/N");
                        choice = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        switch (choice)
                        {
                            case "Y":
                                Console.Clear();
                                Opdracht2 opdracht2 = new Opdracht2();
                                opdracht2.Start();
                                break;
                            case "N":
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                break;
                        }

                    }
                }

            }

            
        }

        
            }
                    


            }
