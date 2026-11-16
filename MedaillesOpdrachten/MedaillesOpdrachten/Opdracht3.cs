using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht3
    {
        public void Start()
        {
            Console.WriteLine("Opdracht 3 - Tips voor het weer?\nWat voor weer is het?\n\n" +
                "1 - Zonnig\n" +
                "2 - Bewolkt\n" +
                "3 - Regen\n");

            string weer = Console.ReadLine();
            switch (weer)
            {
                case ("1"):
                    Temperatuur();
                    break;
                case ("2"):
                    Temperatuur();
                    break;
                case ("3"):
                    Temperatuur();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Kies een van de geldige opdties!\n");
                    Opdracht3 opdracht3 = new Opdracht3();
                    opdracht3.Start();
                    break;

            }

            void Temperatuur()
            {
                Console.WriteLine("wat is de temperatuur?");
                string temp = Console.ReadLine();
                int i;
                if (Int32.TryParse(temp, out i))
                {
                    if (weer == "1")
                    {

                        if(i >= 5 && i < 10)
                        {
                            Console.WriteLine("De zon schijnt, maar vergis je niet! Trek maar een dikke jas aan.");
                        } else if (i >= 10 && i < 20)
                        {
                            Console.WriteLine("Je hoeft vandaag geen jas te dragen, geniet van de zon!");
                        }
                        else if (i >= 20 && i < 30)
                        {
                            Console.WriteLine("Je hoeft vandaag geen jas te dragen, geniet van de zon!");
                        }
                        else if (i >= 30)
                        {
                            Console.WriteLine("Het wordt erg heet vandaag! Pas op dat je niet verbrandt en vergeet niet goed te drinken.");
                        } else
                        {
                            Console.WriteLine("Het is behoorlijk koud vandaag! Kleed je warm aan.");
                        }
                    }
                    else if (weer == "2")
                    {
                        if (i >= 5 && i < 10)
                        {
                            Console.WriteLine("Grijs en koud! Tijd voor een dikke jas en misschien een warme chocolademelk.");
                        }
                        else if (i >= 10 && i < 15)
                        {
                            Console.WriteLine("Trek een jas aan, want zonder zon voelt het best fris!");
                        }
                        else if (i >= 15 && i < 20)
                        {
                            Console.WriteLine("Een vestje is waarschijnlijk genoeg. Ideaal wandelweer!");
                        }
                        else if (i >= 20 && i < 25)
                        {
                            Console.WriteLine("Prima temperatuur. Misschien komt de zon straks nog tevoorschijn!");
                        }
                        else if (i >= 25 && i < 30)
                        {
                            Console.WriteLine("Best warm zonder zon! Draag iets luchtigs en drink genoeg water.");
                        }
                        else if (i >= 30)
                        {
                            Console.WriteLine("Ook zonder zon kan het heet zijn. Zoek lekker de schaduw op!");
                        }
                        else
                        {
                            Console.WriteLine("Het is behoorlijk koud vandaag! Kleed je warm aan.");
                        }

                    }
                    else if (weer == "3")
                    {
                        if (i >= 5 && i < 10)
                        {
                            Console.WriteLine("Brrr, koud en nat! Trek een warme jas aan en neem een paraplu mee.");
                        }
                        else if (i >= 10 && i < 20)
                        {
                            Console.WriteLine("Vergeet je regenjas niet. Niemand zit te wachten op natte kleren!");
                        }
                        else if (i >= 20 && i < 25)
                        {
                            Console.WriteLine("Het is warm, maar nat! Een paraplu is je beste vriend vandaag.");
                        }
                        else if (i >= 25)
                        {
                            Console.WriteLine("Warme regen? Trek iets luchtigs aan en pas op voor gladde wegen!");
                        }
                        else
                        {
                            Console.WriteLine("Het is behoorlijk koud vandaag! Kleed je warm aan.");
                        }
                    }
                    
                    
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("vul alleen een nummer in!\n");
                    Temperatuur();
                }

            } 

        }
    }
}
