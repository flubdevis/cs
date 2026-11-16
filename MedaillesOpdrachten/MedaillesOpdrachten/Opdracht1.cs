using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht1
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
}
