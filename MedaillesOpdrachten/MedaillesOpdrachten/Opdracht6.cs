using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht6
    {
        int highest;
        int getal;
        int guess;
        int poging = 1;
        public void Start()
        {
           

            Console.WriteLine("Wat is het hoogste?");
            string highestinput = Console.ReadLine();

            if (Int32.TryParse(highestinput, out highest))
            {
                RandomGen();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("vul alleen een getal in!\n");
                Start();
            }


        }

        public void RandomGen()
        {
            Random rnd = new Random();
            getal = rnd.Next(0, highest);
            Guess();
        }

        public void Guess()
        {
            Console.WriteLine("Poging: "+ poging +"\nRaad het getal! (random nummer tussen 0 en "+highest);
            string guessinput = Console.ReadLine();
            if (Int32.TryParse(guessinput, out guess))
            {
                if (guess == getal)
                {
                    Gewonnen();
                }
                else if (guess > getal)
                {
                    Console.WriteLine("Lager!\n");
                    poging++;
                    Guess();
                } 
                else if (guess < getal)
                {
                    Console.WriteLine("Hoger!\n");
                    poging++;
                    Guess();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("vul alleen een getal in!\n");
                Guess();
            }
        }

        public void Gewonnen()
        {
            Console.WriteLine("Gewonnen!" +
                "\n het getal was"+getal+"" +
                "\n je hebt het geraden in: " +
                ""+poging+" pogingen" +
                "\n wil je nog een keer spelen?\n Y/N");
            String input = Console.ReadLine();
            switch (input)
            {
                case "Y":
                    Start();
                    Console.Clear();
                    poging = 1;
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
